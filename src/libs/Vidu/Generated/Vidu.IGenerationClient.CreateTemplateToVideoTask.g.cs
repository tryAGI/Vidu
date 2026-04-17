#nullable enable

namespace Vidu
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Create Template-to-Video task<br/>
        /// Generates a video using a named template (e.g. hugging, dance) applied to input images.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vidu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateTemplateToVideoTaskAsync(

            global::Vidu.TemplateToVideoRequest request,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Template-to-Video task<br/>
        /// Generates a video using a named template (e.g. hugging, dance) applied to input images.
        /// </summary>
        /// <param name="template">
        /// Template name (e.g. hugging, dance). See Vidu templates list.
        /// </param>
        /// <param name="images">
        /// Input images required by the template.
        /// </param>
        /// <param name="prompt">
        /// Text description. Max 2000 characters.
        /// </param>
        /// <param name="aspectRatio"></param>
        /// <param name="seed"></param>
        /// <param name="bgm"></param>
        /// <param name="offPeak"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="payload"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vidu.VideoTask> CreateTemplateToVideoTaskAsync(
            string template,
            global::System.Collections.Generic.IList<string> images,
            string? prompt = default,
            global::Vidu.TemplateToVideoRequestAspectRatio? aspectRatio = default,
            int? seed = default,
            bool? bgm = default,
            bool? offPeak = default,
            string? callbackUrl = default,
            string? payload = default,
            global::Vidu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}