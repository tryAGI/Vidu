
#nullable enable

namespace Vidu
{
    /// <summary>
    /// Task object returned when a generation request is created.
    /// </summary>
    public sealed partial class VideoTask
    {
        /// <summary>
        /// Unique task identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Task lifecycle state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.TaskStateJsonConverter))]
        public global::Vidu.TaskState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videos")]
        public global::System.Collections.Generic.IList<string>? Videos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bgm")]
        public bool? Bgm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("movement_amplitude")]
        public string? MovementAmplitude { get; set; }

        /// <summary>
        /// Credits consumed by the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public int? Credits { get; set; }

        /// <summary>
        /// Creation timestamp (ISO 8601).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Error code present on failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("err_code")]
        public string? ErrCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTask" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique task identifier.
        /// </param>
        /// <param name="state">
        /// Task lifecycle state.
        /// </param>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="images"></param>
        /// <param name="videos"></param>
        /// <param name="duration"></param>
        /// <param name="seed"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="resolution"></param>
        /// <param name="bgm"></param>
        /// <param name="movementAmplitude"></param>
        /// <param name="credits">
        /// Credits consumed by the task.
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp (ISO 8601).
        /// </param>
        /// <param name="errCode">
        /// Error code present on failure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTask(
            string? taskId,
            global::Vidu.TaskState? state,
            string? model,
            string? prompt,
            global::System.Collections.Generic.IList<string>? images,
            global::System.Collections.Generic.IList<string>? videos,
            int? duration,
            int? seed,
            string? aspectRatio,
            string? resolution,
            bool? bgm,
            string? movementAmplitude,
            int? credits,
            global::System.DateTime? createdAt,
            string? errCode)
        {
            this.TaskId = taskId;
            this.State = state;
            this.Model = model;
            this.Prompt = prompt;
            this.Images = images;
            this.Videos = videos;
            this.Duration = duration;
            this.Seed = seed;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Bgm = bgm;
            this.MovementAmplitude = movementAmplitude;
            this.Credits = credits;
            this.CreatedAt = createdAt;
            this.ErrCode = errCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTask" /> class.
        /// </summary>
        public VideoTask()
        {
        }

    }
}