
#nullable enable

namespace Vidu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferenceToVideoRequest
    {
        /// <summary>
        /// Vidu model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vidu.Model Model { get; set; }

        /// <summary>
        /// Text description of the desired video. Max 5000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 1-7 reference images (URL or base64 data URI). PNG/JPEG/JPG/WebP, min 128x128, aspect ratio between 1:4 and 4:1, 50MB total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

        /// <summary>
        /// Reference videos (viduq2-pro only). Max 1 video (8s) or 2 videos (5s each). mp4/avi/mov.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videos")]
        public global::System.Collections.Generic.IList<string>? Videos { get; set; }

        /// <summary>
        /// Duration in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Output aspect ratio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.AspectRatioJsonConverter))]
        public global::Vidu.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Output video resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.ResolutionJsonConverter))]
        public global::Vidu.Resolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Camera movement amplitude.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("movement_amplitude")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.MovementAmplitudeJsonConverter))]
        public global::Vidu.MovementAmplitude? MovementAmplitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bgm")]
        public bool? Bgm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

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
        /// Initializes a new instance of the <see cref="ReferenceToVideoRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferenceToVideoRequest(
            global::Vidu.Model model,
            string prompt,
            global::System.Collections.Generic.IList<string>? images,
            global::System.Collections.Generic.IList<string>? videos,
            int? duration,
            global::Vidu.AspectRatio? aspectRatio,
            global::Vidu.Resolution? resolution,
            int? seed,
            global::Vidu.MovementAmplitude? movementAmplitude,
            bool? bgm,
            bool? audio,
            bool? offPeak,
            string? callbackUrl,
            string? payload)
        {
            this.Model = model;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Images = images;
            this.Videos = videos;
            this.Duration = duration;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Seed = seed;
            this.MovementAmplitude = movementAmplitude;
            this.Bgm = bgm;
            this.Audio = audio;
            this.OffPeak = offPeak;
            this.CallbackUrl = callbackUrl;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceToVideoRequest" /> class.
        /// </summary>
        public ReferenceToVideoRequest()
        {
        }
    }
}