
#nullable enable

namespace Vidu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StartEndToVideoRequest
    {
        /// <summary>
        /// Vidu model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vidu.Model Model { get; set; }

        /// <summary>
        /// Array of exactly two images (start frame, end frame). PNG/JPEG/JPG/WebP, aspect ratio 0.8 to 1.25.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Images { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

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
        /// Initializes a new instance of the <see cref="StartEndToVideoRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartEndToVideoRequest(
            global::Vidu.Model model,
            global::System.Collections.Generic.IList<string> images,
            string? prompt,
            int? duration,
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
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Prompt = prompt;
            this.Duration = duration;
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
        /// Initializes a new instance of the <see cref="StartEndToVideoRequest" /> class.
        /// </summary>
        public StartEndToVideoRequest()
        {
        }

    }
}