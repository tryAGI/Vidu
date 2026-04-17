#pragma warning disable CS3002 // Return type is not CLS-compliant
using Microsoft.Extensions.AI;

namespace Vidu;

/// <summary>
/// Extensions for using <see cref="ViduClient"/> as MEAI <see cref="AIFunction"/> tools with any <c>IChatClient</c>.
/// </summary>
public static class ViduToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a video from a text prompt
    /// using Vidu's Text-to-Video API. Returns the created task ID and state.
    /// </summary>
    /// <param name="client">The Vidu client to use.</param>
    /// <param name="model">Vidu model to use (default: viduq3-turbo).</param>
    /// <param name="aspectRatio">Aspect ratio of the output video (default: 16:9).</param>
    /// <param name="resolution">Output resolution (default: 720p).</param>
    /// <param name="duration">Duration in seconds (default: 5).</param>
    /// <returns>An <see cref="AIFunction"/> that can be passed to <c>ChatOptions.Tools</c>.</returns>
    public static AIFunction AsTextToVideoTool(
        this ViduClient client,
        Model model = Model.Viduq3Turbo,
        AspectRatio aspectRatio = AspectRatio.x16_9,
        Resolution resolution = Resolution.x720p,
        int duration = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, int? seed, CancellationToken cancellationToken) =>
            {
                var response = await client.Generation.CreateTextToVideoTaskAsync(
                    model: model,
                    prompt: prompt,
                    duration: duration,
                    aspectRatio: aspectRatio,
                    resolution: resolution,
                    seed: seed,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTask(response, "text-to-video");
            },
            name: "TextToVideo",
            description: "Generates a video from a text description using Vidu. Provide a detailed prompt describing the desired scene, subjects, motion, and style. Returns a task ID that can be used to check generation status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a video from a single reference image
    /// using Vidu's Image-to-Video API. Returns the created task ID and state.
    /// </summary>
    /// <param name="client">The Vidu client to use.</param>
    /// <param name="model">Vidu model to use (default: viduq3-turbo).</param>
    /// <param name="resolution">Output resolution (default: 720p).</param>
    /// <param name="duration">Duration in seconds (default: 5).</param>
    /// <returns>An <see cref="AIFunction"/> that can be passed to <c>ChatOptions.Tools</c>.</returns>
    public static AIFunction AsImageToVideoTool(
        this ViduClient client,
        Model model = Model.Viduq3Turbo,
        Resolution resolution = Resolution.x720p,
        int duration = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string imageUrl, string? prompt, CancellationToken cancellationToken) =>
            {
                var response = await client.Generation.CreateImageToVideoTaskAsync(
                    model: model,
                    images: new List<string> { imageUrl },
                    prompt: prompt,
                    duration: duration,
                    resolution: resolution,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTask(response, "image-to-video");
            },
            name: "ImageToVideo",
            description: "Generates a video from a single reference image URL using Vidu. Optionally accepts a text prompt to guide motion and content. Returns a task ID that can be used to check generation status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a video using multiple reference images
    /// for subject consistency (Vidu's differentiated Reference-to-Video feature).
    /// Returns the created task ID and state.
    /// </summary>
    /// <param name="client">The Vidu client to use.</param>
    /// <param name="model">Vidu model to use (default: viduq3-turbo).</param>
    /// <param name="aspectRatio">Aspect ratio of the output video (default: 16:9).</param>
    /// <param name="resolution">Output resolution (default: 720p).</param>
    /// <param name="duration">Duration in seconds (default: 5).</param>
    /// <returns>An <see cref="AIFunction"/> that can be passed to <c>ChatOptions.Tools</c>.</returns>
    public static AIFunction AsReferenceToVideoTool(
        this ViduClient client,
        Model model = Model.Viduq3Turbo,
        AspectRatio aspectRatio = AspectRatio.x16_9,
        Resolution resolution = Resolution.x720p,
        int duration = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, IList<string> imageUrls, CancellationToken cancellationToken) =>
            {
                var response = await client.Generation.CreateReferenceToVideoTaskAsync(
                    model: model,
                    prompt: prompt,
                    images: imageUrls,
                    duration: duration,
                    aspectRatio: aspectRatio,
                    resolution: resolution,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTask(response, "reference-to-video");
            },
            name: "ReferenceToVideo",
            description: "Generates a video from 1-7 reference images with multi-subject consistency using Vidu's Reference-to-Video. The text prompt describes the scene; each reference image supplies a subject (person, character, object) to preserve across frames. Returns a task ID.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a video transitioning between
    /// a start frame and end frame using Vidu's Start-End-to-Video API. Returns the
    /// created task ID and state.
    /// </summary>
    /// <param name="client">The Vidu client to use.</param>
    /// <param name="model">Vidu model to use (default: viduq3-turbo).</param>
    /// <param name="resolution">Output resolution (default: 720p).</param>
    /// <param name="duration">Duration in seconds (default: 5).</param>
    /// <returns>An <see cref="AIFunction"/> that can be passed to <c>ChatOptions.Tools</c>.</returns>
    public static AIFunction AsStartEndToVideoTool(
        this ViduClient client,
        Model model = Model.Viduq3Turbo,
        Resolution resolution = Resolution.x720p,
        int duration = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string startImageUrl, string endImageUrl, string? prompt, CancellationToken cancellationToken) =>
            {
                var response = await client.Generation.CreateStartEndToVideoTaskAsync(
                    model: model,
                    images: new List<string> { startImageUrl, endImageUrl },
                    prompt: prompt,
                    duration: duration,
                    resolution: resolution,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTask(response, "start-end-to-video");
            },
            name: "StartEndToVideo",
            description: "Generates a video that smoothly transitions from a start frame image to an end frame image using Vidu. Optionally accepts a prompt describing the motion in between. Returns a task ID.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status and generated output URLs
    /// for a Vidu task by its ID.
    /// </summary>
    /// <param name="client">The Vidu client to use.</param>
    /// <returns>An <see cref="AIFunction"/> that can be passed to <c>ChatOptions.Tools</c>.</returns>
    public static AIFunction AsGetTaskCreationsTool(this ViduClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string taskId, CancellationToken cancellationToken) =>
            {
                var response = await client.Tasks.GetTaskCreationsAsync(
                    id: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTaskCreations(response);
            },
            name: "GetTaskCreations",
            description: "Retrieves the status and generated output URLs for a Vidu generation task. Returns the task state (created, queueing, processing, success, failed) and the URLs of any generated video/image creations.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that upscales a previously generated video
    /// (or a publicly reachable video URL) to a higher resolution.
    /// </summary>
    /// <param name="client">The Vidu client to use.</param>
    /// <param name="resolution">Target resolution (default: 1080p). Must be higher than source.</param>
    /// <returns>An <see cref="AIFunction"/> that can be passed to <c>ChatOptions.Tools</c>.</returns>
    public static AIFunction AsUpscaleTool(
        this ViduClient client,
        UpscaleRequestResolution resolution = UpscaleRequestResolution.x1080p)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? videoCreationId, string? videoUrl, CancellationToken cancellationToken) =>
            {
                var response = await client.Generation.CreateUpscaleTaskAsync(
                    videoUrl: videoUrl,
                    videoCreationId: videoCreationId,
                    resolution: resolution,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTask(response, "upscale");
            },
            name: "UpscaleVideo",
            description: "Upscales a video to a higher resolution (1080p, 2K, 4K, or 8K) using Vidu. Provide either a video_creation_id from a previous task, or a publicly reachable video_url. Returns a task ID.");
    }

    private static string FormatTask(VideoTask task, string taskType)
    {
        var parts = new List<string>
        {
            $"Task created ({taskType}).",
        };

        if (!string.IsNullOrWhiteSpace(task.TaskId))
        {
            parts.Add($"Task ID: {task.TaskId}");
        }
        if (task.State is { } state)
        {
            parts.Add($"State: {state.ToValueString()}");
        }
        if (task.Credits is { } credits)
        {
            parts.Add($"Credits: {credits}");
        }
        if (!string.IsNullOrWhiteSpace(task.ErrCode))
        {
            parts.Add($"Error: {task.ErrCode}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatTaskCreations(TaskCreations response)
    {
        var parts = new List<string>();

        if (response.State is { } state)
        {
            parts.Add($"State: {state.ToValueString()}");
        }
        if (response.Credits is { } credits)
        {
            parts.Add($"Credits: {credits}");
        }
        if (!string.IsNullOrWhiteSpace(response.ErrCode))
        {
            parts.Add($"Error: {response.ErrCode}");
        }

        if (response.Creations is { Count: > 0 })
        {
            parts.Add("Creations:");
            foreach (var creation in response.Creations)
            {
                var entry = $"- id={creation.Id ?? "(none)"} url={creation.Url}";
                if (!string.IsNullOrWhiteSpace(creation.CoverUrl))
                {
                    entry += $" cover={creation.CoverUrl}";
                }
                parts.Add(entry);
            }
        }

        if (parts.Count == 0)
        {
            parts.Add("No task details available.");
        }

        return string.Join("\n", parts);
    }
}
