#nullable enable

namespace Vidu
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Create Lip Sync task<br/>
        /// Synchronizes lip movements in a video with provided audio or generated speech.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateLipSyncTaskAsync(

            global::Vidu.LipSyncRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Lip Sync task<br/>
        /// Synchronizes lip movements in a video with provided audio or generated speech.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.AutoSDKHttpResponse<global::Vidu.VideoTask>> CreateLipSyncTaskAsResponseAsync(

            global::Vidu.LipSyncRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Lip Sync task<br/>
        /// Synchronizes lip movements in a video with provided audio or generated speech.
        /// </summary>
        /// <param name="videoUrl">
        /// Source video URL (mp4/mov/avi, H.264, 1-600s, less than 5GB).
        /// </param>
        /// <param name="audioUrl">
        /// Audio file URL to drive lip sync. Required if text is not provided.
        /// </param>
        /// <param name="text">
        /// Text to synthesize into speech and lip-sync. Required if audio_url is not provided.
        /// </param>
        /// <param name="voiceId">
        /// Voice identifier for text-to-speech mode.
        /// </param>
        /// <param name="speed">
        /// Speech rate (0.5-1.5). Default 1.0.
        /// </param>
        /// <param name="refPhotoUrl">
        /// Face reference image URL when the video contains multiple faces.
        /// </param>
        /// <param name="callbackUrl"></param>
        /// <param name="payload"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateLipSyncTaskAsync(
            string videoUrl,
            string? audioUrl = default,
            string? text = default,
            string? voiceId = default,
            double? speed = default,
            string? refPhotoUrl = default,
            string? callbackUrl = default,
            string? payload = default,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}