#nullable enable

namespace Vidu
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Create Reference-to-Video task<br/>
        /// Generates a video using multiple reference images or videos for subject consistency.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateReferenceToVideoTaskAsync(

            global::Vidu.ReferenceToVideoRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Reference-to-Video task<br/>
        /// Generates a video using multiple reference images or videos for subject consistency.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.AutoSDKHttpResponse<global::Vidu.VideoTask>> CreateReferenceToVideoTaskAsResponseAsync(

            global::Vidu.ReferenceToVideoRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Reference-to-Video task<br/>
        /// Generates a video using multiple reference images or videos for subject consistency.
        /// </summary>
        /// <param name="model">
        /// Vidu model name.
        /// </param>
        /// <param name="prompt">
        /// Text description of the desired video. Max 5000 characters.
        /// </param>
        /// <param name="images">
        /// 1-7 reference images (URL or base64 data URI). PNG/JPEG/JPG/WebP, min 128x128, aspect ratio between 1:4 and 4:1, 50MB total.
        /// </param>
        /// <param name="videos">
        /// Reference videos (viduq2-pro only). Max 1 video (8s) or 2 videos (5s each). mp4/avi/mov.
        /// </param>
        /// <param name="duration">
        /// Duration in seconds.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio.
        /// </param>
        /// <param name="resolution">
        /// Output video resolution.
        /// </param>
        /// <param name="seed"></param>
        /// <param name="movementAmplitude">
        /// Camera movement amplitude.
        /// </param>
        /// <param name="bgm"></param>
        /// <param name="audio"></param>
        /// <param name="offPeak"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="payload"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateReferenceToVideoTaskAsync(
            global::Vidu.Model model,
            string prompt,
            global::System.Collections.Generic.IList<string>? images = default,
            global::System.Collections.Generic.IList<string>? videos = default,
            int? duration = default,
            global::Vidu.AspectRatio? aspectRatio = default,
            global::Vidu.Resolution? resolution = default,
            int? seed = default,
            global::Vidu.MovementAmplitude? movementAmplitude = default,
            bool? bgm = default,
            bool? audio = default,
            bool? offPeak = default,
            string? callbackUrl = default,
            string? payload = default,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}