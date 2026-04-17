
#nullable enable

namespace Vidu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferenceToImageRequest
    {
        /// <summary>
        /// Image generation model (viduq1 or viduq2).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.ReferenceToImageRequestModelJsonConverter))]
        public global::Vidu.ReferenceToImageRequestModel? Model { get; set; }

        /// <summary>
        /// Text description. Max 2000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 0-7 reference images (viduq2) or 1-7 (viduq1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.ReferenceToImageRequestAspectRatioJsonConverter))]
        public global::Vidu.ReferenceToImageRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.ReferenceToImageRequestResolutionJsonConverter))]
        public global::Vidu.ReferenceToImageRequestResolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        /// Initializes a new instance of the <see cref="ReferenceToImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text description. Max 2000 characters.
        /// </param>
        /// <param name="model">
        /// Image generation model (viduq1 or viduq2).
        /// </param>
        /// <param name="images">
        /// 0-7 reference images (viduq2) or 1-7 (viduq1).
        /// </param>
        /// <param name="aspectRatio"></param>
        /// <param name="resolution"></param>
        /// <param name="seed"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="payload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferenceToImageRequest(
            string prompt,
            global::Vidu.ReferenceToImageRequestModel? model,
            global::System.Collections.Generic.IList<string>? images,
            global::Vidu.ReferenceToImageRequestAspectRatio? aspectRatio,
            global::Vidu.ReferenceToImageRequestResolution? resolution,
            int? seed,
            string? callbackUrl,
            string? payload)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Seed = seed;
            this.CallbackUrl = callbackUrl;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceToImageRequest" /> class.
        /// </summary>
        public ReferenceToImageRequest()
        {
        }
    }
}