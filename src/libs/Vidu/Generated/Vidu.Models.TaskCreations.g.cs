
#nullable enable

namespace Vidu
{
    /// <summary>
    /// Status and generated outputs of a task.
    /// </summary>
    public sealed partial class TaskCreations
    {
        /// <summary>
        /// Task lifecycle state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vidu.JsonConverters.TaskStateJsonConverter))]
        public global::Vidu.TaskState? State { get; set; }

        /// <summary>
        /// Error code present on failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("err_code")]
        public string? ErrCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public int? Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public string? Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creations")]
        public global::System.Collections.Generic.IList<global::Vidu.Creation>? Creations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCreations" /> class.
        /// </summary>
        /// <param name="state">
        /// Task lifecycle state.
        /// </param>
        /// <param name="errCode">
        /// Error code present on failure.
        /// </param>
        /// <param name="credits"></param>
        /// <param name="payload"></param>
        /// <param name="creations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskCreations(
            global::Vidu.TaskState? state,
            string? errCode,
            int? credits,
            string? payload,
            global::System.Collections.Generic.IList<global::Vidu.Creation>? creations)
        {
            this.State = state;
            this.ErrCode = errCode;
            this.Credits = credits;
            this.Payload = payload;
            this.Creations = creations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCreations" /> class.
        /// </summary>
        public TaskCreations()
        {
        }

    }
}