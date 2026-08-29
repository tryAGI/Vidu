
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vidu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Vidu.Model? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.AspectRatio? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.Resolution? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.MovementAmplitude? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.TaskState? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.TextToVideoRequest? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.ImageToVideoRequest? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.ReferenceToVideoRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.StartEndToVideoRequest? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.TemplateToVideoRequest? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.TemplateToVideoRequestAspectRatio? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.LipSyncRequest? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.ReferenceToImageRequest? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.ReferenceToImageRequestModel? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.ReferenceToImageRequestAspectRatio? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.ReferenceToImageRequestResolution? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.UpscaleRequest? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.UpscaleRequestResolution? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.VideoTask? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.Creation? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vidu.TaskCreations? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vidu.Creation>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type28 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vidu.Creation>? ListType1 { get; set; }
    }
}