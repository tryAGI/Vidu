#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (Vidu has no public OpenAPI spec).
# Spec was handcrafted from https://platform.vidu.com/docs (viduhq/api-docs on
# GitHub covers a different, unrelated legacy "vidu.io" sales-video product).

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

autosdk generate openapi.yaml \
  --namespace Vidu \
  --clientClassName ViduClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
