# CLAUDE.md -- Vidu SDK

## Overview

Auto-generated C# SDK for [Vidu](https://platform.vidu.com/) by Shengshu Tech -- AI-powered video
generation with text-to-video, image-to-video, **reference-to-video** (multi-subject consistency),
start-end-to-video, template-to-video, lip sync, reference-to-image, and video upscaling.

**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Vidu's
[platform docs](https://platform.vidu.com/docs). The official `viduhq/api-docs` GitHub repo
covers a *different, unrelated* sales-video product (vidu.io) and was not used.

## Build & Test

```bash
dotnet build Vidu.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth using Vidu's custom `Token` scheme (not `Bearer`):

```csharp
var client = new ViduClient(apiKey); // VIDU_API_KEY env var
```

Base URL: `https://api.vidu.com/ent/v2`.

**Important:** Vidu expects `Authorization: Token <key>`, not `Authorization: Bearer <key>`.
The `Authorized` partial hook in `ViduClient.Auth.cs` rewrites the scheme at runtime:

```csharp
// In Extensions/ViduClient.Auth.cs
partial void Authorized(HttpClient client)
{
    for (int i = 0; i < Authorizations.Count; i++)
    {
        var auth = Authorizations[i];
        if (auth is { Type: "Http", Name: "Bearer" })
            Authorizations[i] = new EndPointAuthorization
            { Type = auth.Type, Location = auth.Location, Name = "Token", Value = auth.Value };
    }
}
```

`--security-scheme Http:Header:Bearer` is not set explicitly (the spec already declares
Bearer security), but the `Authorized` hook is still required because Vidu's custom scheme
name (`Token`) is not expressible via `--security-scheme`.

## Key Files

- `src/libs/Vidu/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Vidu)
- `src/libs/Vidu/generate.sh` -- Runs autosdk on the local spec (no download step)
- `src/libs/Vidu/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Vidu/Extensions/ViduClient.Auth.cs` -- REST auth fix: Bearer -> Token
- `src/libs/Vidu/Extensions/ViduClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with Token auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-Client Layout

Operations are grouped into two sub-clients on `ViduClient`:

| Sub-client | Endpoints |
|------------|-----------|
| `client.Generation` | `text2video`, `img2video`, `reference2video`, `start-end2video`, `template2video`, `lip-sync`, `reference2image`, `upscale-new` |
| `client.Tasks` | `tasks/{id}/creations` (GET status + outputs), `tasks/{id}/cancel` (POST cancel) |

## Async Task Pattern

Three-step generation workflow:
1. **Create:** `client.Generation.CreateTextToVideoTaskAsync(...)` returns a `VideoTask` with
   `TaskId` and `State` (`created` | `queueing` | `processing` | `success` | `failed`).
2. **Poll:** `client.Tasks.GetTaskCreationsAsync(taskId)` returns `TaskCreations` with the
   current `State`, `Creations` (result URLs, valid 24h), and `ErrCode` on failure.
3. **Cancel (optional):** `client.Tasks.CancelTaskAsync(taskId)` -- some states cannot be cancelled.

## Spec Notes

- **Schema rename:** The `Task` schema was renamed to `VideoTask` in the OpenAPI spec to avoid
  a clash with `System.Threading.Tasks.Task` (which MSTest test methods return).
- **Upscale endpoint path:** Vidu's upscale endpoint is `/upscale-new` (not `/upscale`) per
  the current platform docs.
- No sub-client-level auth overrides; the Bearer->Token rewrite happens once on the shared
  `Authorizations` list and is visible to all sub-clients.

## MEAI Integration

**No MEAI interface is implemented** -- Vidu is a video generation platform with no matching
MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`).

AIFunction tools for use with any `IChatClient`:
- `AsTextToVideoTool(model, aspectRatio, resolution, duration)` -- text prompt -> video task
- `AsImageToVideoTool(model, resolution, duration)` -- single image + optional prompt -> video task
- `AsReferenceToVideoTool(model, aspectRatio, resolution, duration)` -- multi-subject consistency
- `AsStartEndToVideoTool(model, resolution, duration)` -- interpolate between two frames
- `AsGetTaskCreationsTool()` -- poll task state + collect result URLs
- `AsUpscaleTool(resolution)` -- upscale to 1080p/2K/4K/8K

## Known Issues

- **Token auth:** Custom `Token` scheme (not standard Bearer); fixed via `Authorized` hook.
- **Task schema name collision:** Renamed in spec to `VideoTask` to avoid conflict with
  `System.Threading.Tasks.Task` in test code.
