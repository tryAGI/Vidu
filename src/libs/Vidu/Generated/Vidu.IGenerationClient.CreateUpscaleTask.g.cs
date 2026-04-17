#nullable enable

namespace Vidu
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Create Upscale task<br/>
        /// Upscales a video to a higher resolution (1080p, 2K, 4K, or 8K).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateUpscaleTaskAsync(

            global::Vidu.UpscaleRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Upscale task<br/>
        /// Upscales a video to a higher resolution (1080p, 2K, 4K, or 8K).
        /// </summary>
        /// <param name="videoUrl">
        /// Directly accessible video URL. Either this or video_creation_id is required.
        /// </param>
        /// <param name="videoCreationId">
        /// Creation ID from a previous Vidu generation task. Takes priority over video_url.
        /// </param>
        /// <param name="resolution">
        /// Target resolution. Must be higher than the source resolution.
        /// </param>
        /// <param name="offPeak"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="payload"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateUpscaleTaskAsync(
            string? videoUrl = default,
            string? videoCreationId = default,
            global::Vidu.UpscaleRequestResolution? resolution = default,
            bool? offPeak = default,
            string? callbackUrl = default,
            string? payload = default,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}