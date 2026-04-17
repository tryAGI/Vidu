
#nullable enable

namespace Vidu
{
    /// <summary>
    /// A single generated output associated with a task.
    /// </summary>
    public sealed partial class Creation
    {
        /// <summary>
        /// Creation identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Result URL (valid 24 hours).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Cover/poster image URL (valid 24 hours).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_url")]
        public string? CoverUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Creation" /> class.
        /// </summary>
        /// <param name="id">
        /// Creation identifier.
        /// </param>
        /// <param name="url">
        /// Result URL (valid 24 hours).
        /// </param>
        /// <param name="coverUrl">
        /// Cover/poster image URL (valid 24 hours).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Creation(
            string? id,
            string? url,
            string? coverUrl)
        {
            this.Id = id;
            this.Url = url;
            this.CoverUrl = coverUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Creation" /> class.
        /// </summary>
        public Creation()
        {
        }
    }
}