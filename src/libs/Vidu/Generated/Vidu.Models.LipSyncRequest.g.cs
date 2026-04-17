
#nullable enable

namespace Vidu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LipSyncRequest
    {
        /// <summary>
        /// Source video URL (mp4/mov/avi, H.264, 1-600s, less than 5GB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoUrl { get; set; }

        /// <summary>
        /// Audio file URL to drive lip sync. Required if text is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Text to synthesize into speech and lip-sync. Required if audio_url is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Voice identifier for text-to-speech mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Speech rate (0.5-1.5). Default 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Face reference image URL when the video contains multiple faces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref_photo_url")]
        public string? RefPhotoUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="LipSyncRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LipSyncRequest(
            string videoUrl,
            string? audioUrl,
            string? text,
            string? voiceId,
            double? speed,
            string? refPhotoUrl,
            string? callbackUrl,
            string? payload)
        {
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
            this.AudioUrl = audioUrl;
            this.Text = text;
            this.VoiceId = voiceId;
            this.Speed = speed;
            this.RefPhotoUrl = refPhotoUrl;
            this.CallbackUrl = callbackUrl;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LipSyncRequest" /> class.
        /// </summary>
        public LipSyncRequest()
        {
        }
    }
}