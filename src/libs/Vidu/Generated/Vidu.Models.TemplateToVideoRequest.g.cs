
#nullable enable

namespace Vidu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateToVideoRequest
    {
        /// <summary>
        /// Template name (e.g. hugging, dance). See Vidu templates list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Template { get; set; }

        /// <summary>
        /// Input images required by the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>
        /// Text description. Max 2000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.TemplateToVideoRequestAspectRatioJsonConverter))]
        public global::Vidu.TemplateToVideoRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bgm")]
        public bool? Bgm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("off_peak")]
        public bool? OffPeak { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public string? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateToVideoRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateToVideoRequest(
            string template,
            global::System.Collections.Generic.IList<string> images,
            string? prompt,
            global::Vidu.TemplateToVideoRequestAspectRatio? aspectRatio,
            int? seed,
            bool? bgm,
            bool? offPeak,
            string? callbackUrl,
            string? payload)
        {
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Prompt = prompt;
            this.AspectRatio = aspectRatio;
            this.Seed = seed;
            this.Bgm = bgm;
            this.OffPeak = offPeak;
            this.CallbackUrl = callbackUrl;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateToVideoRequest" /> class.
        /// </summary>
        public TemplateToVideoRequest()
        {
        }
    }
}