
#nullable enable

namespace Vidu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpscaleRequest
    {
        /// <summary>
        /// Directly accessible video URL. Either this or video_creation_id is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Creation ID from a previous Vidu generation task. Takes priority over video_url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_creation_id")]
        public string? VideoCreationId { get; set; }

        /// <summary>
        /// Target resolution. Must be higher than the source resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.UpscaleRequestResolutionJsonConverter))]
        public global::Vidu.UpscaleRequestResolution? Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="UpscaleRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpscaleRequest(
            string? videoUrl,
            string? videoCreationId,
            global::Vidu.UpscaleRequestResolution? resolution,
            bool? offPeak,
            string? callbackUrl,
            string? payload)
        {
            this.VideoUrl = videoUrl;
            this.VideoCreationId = videoCreationId;
            this.Resolution = resolution;
            this.OffPeak = offPeak;
            this.CallbackUrl = callbackUrl;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleRequest" /> class.
        /// </summary>
        public UpscaleRequest()
        {
        }
    }
}