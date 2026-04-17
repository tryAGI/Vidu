#nullable enable

namespace Vidu
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Create Reference-to-Image task<br/>
        /// Generates images from text prompts and optional reference images.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateReferenceToImageTaskAsync(

            global::Vidu.ReferenceToImageRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Reference-to-Image task<br/>
        /// Generates images from text prompts and optional reference images.
        /// </summary>
        /// <param name="model">
        /// Image generation model (viduq1 or viduq2).
        /// </param>
        /// <param name="prompt">
        /// Text description. Max 2000 characters.
        /// </param>
        /// <param name="images">
        /// 0-7 reference images (viduq2) or 1-7 (viduq1).
        /// </param>
        /// <param name="aspectRatio"></param>
        /// <param name="resolution"></param>
        /// <param name="seed"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="payload"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateReferenceToImageTaskAsync(
            string prompt,
            global::Vidu.ReferenceToImageRequestModel? model = default,
            global::System.Collections.Generic.IList<string>? images = default,
            global::Vidu.ReferenceToImageRequestAspectRatio? aspectRatio = default,
            global::Vidu.ReferenceToImageRequestResolution? resolution = default,
            int? seed = default,
            string? callbackUrl = default,
            string? payload = default,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}