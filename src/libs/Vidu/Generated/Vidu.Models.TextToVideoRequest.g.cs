
#nullable enable

namespace Vidu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextToVideoRequest
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
        /// Duration in seconds. Model-dependent (typically 1-16).
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
        /// Random seed for reproducibility.
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
        /// Add auto-generated background music.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bgm")]
        public bool? Bgm { get; set; }

        /// <summary>
        /// Enable audio-video synchronization (viduq3 models only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Run in off-peak mode (lower cost, up to 48h completion).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("off_peak")]
        public bool? OffPeak { get; set; }

        /// <summary>
        /// Webhook URL for status updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Custom passthrough data (max 1,048,576 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public string? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToVideoRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Vidu model name.
        /// </param>
        /// <param name="prompt">
        /// Text description of the desired video. Max 5000 characters.
        /// </param>
        /// <param name="duration">
        /// Duration in seconds. Model-dependent (typically 1-16).
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio.
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
        /// Run in off-peak mode (lower cost, up to 48h completion).
        /// </param>
        /// <param name="callbackUrl">
        /// Webhook URL for status updates.
        /// </param>
        /// <param name="payload">
        /// Custom passthrough data (max 1,048,576 characters).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToVideoRequest(
            global::Vidu.Model model,
            string prompt,
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
        /// Initializes a new instance of the <see cref="TextToVideoRequest" /> class.
        /// </summary>
        public TextToVideoRequest()
        {
        }

    }
}