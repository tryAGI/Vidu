#nullable enable

namespace Vidu
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Create Image-to-Video task<br/>
        /// Generates a video from a single reference image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateImageToVideoTaskAsync(

            global::Vidu.ImageToVideoRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Image-to-Video task<br/>
        /// Generates a video from a single reference image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.AutoSDKHttpResponse<global::Vidu.VideoTask>> CreateImageToVideoTaskAsResponseAsync(

            global::Vidu.ImageToVideoRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Image-to-Video task<br/>
        /// Generates a video from a single reference image.
        /// </summary>
        /// <param name="model">
        /// Vidu model name.
        /// </param>
        /// <param name="images">
        /// Reference image as array of exactly one URL or base64 data URI.
        /// </param>
        /// <param name="prompt">
        /// Text description to guide the motion. Max 5000 characters.
        /// </param>
        /// <param name="duration">
        /// Duration in seconds. Model-dependent.
        /// </param>
        /// <param name="resolution">
        /// Output video resolution.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="movementAmplitude">
        /// Camera movement amplitude.
        /// </param>
        /// <param name="bgm">
        /// Add auto-generated background music.
        /// </param>
        /// <param name="audio">
        /// Enable audio-video synchronization (viduq3 models only).
        /// </param>
        /// <param name="offPeak">
        /// Run in off-peak mode.
        /// </param>
        /// <param name="callbackUrl">
        /// Webhook URL for status updates.
        /// </param>
        /// <param name="payload">
        /// Custom passthrough data.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateImageToVideoTaskAsync(
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