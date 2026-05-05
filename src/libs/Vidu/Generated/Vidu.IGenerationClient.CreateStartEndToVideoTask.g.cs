#nullable enable

namespace Vidu
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Create Start-End-to-Video task<br/>
        /// Generates a video that transitions between a start and end frame.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateStartEndToVideoTaskAsync(

            global::Vidu.StartEndToVideoRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Start-End-to-Video task<br/>
        /// Generates a video that transitions between a start and end frame.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.AutoSDKHttpResponse<global::Vidu.VideoTask>> CreateStartEndToVideoTaskAsResponseAsync(

            global::Vidu.StartEndToVideoRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Start-End-to-Video task<br/>
        /// Generates a video that transitions between a start and end frame.
        /// </summary>
        /// <param name="model">
        /// Vidu model name.
        /// </param>
        /// <param name="images">
        /// Array of exactly two images (start frame, end frame). PNG/JPEG/JPG/WebP, aspect ratio 0.8 to 1.25.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="duration"></param>
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
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateStartEndToVideoTaskAsync(
            global::Vidu.Model model,
            global::System.Collections.Generic.IList<string> images,
            string? prompt = default,
            int? duration = default,
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