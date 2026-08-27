
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vidu
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Vidu.JsonConverters.ModelJsonConverter),

            typeof(global::Vidu.JsonConverters.ModelNullableJsonConverter),

            typeof(global::Vidu.JsonConverters.AspectRatioJsonConverter),

            typeof(global::Vidu.JsonConverters.AspectRatioNullableJsonConverter),

            typeof(global::Vidu.JsonConverters.ResolutionJsonConverter),

            typeof(global::Vidu.JsonConverters.ResolutionNullableJsonConverter),

            typeof(global::Vidu.JsonConverters.MovementAmplitudeJsonConverter),

            typeof(global::Vidu.JsonConverters.MovementAmplitudeNullableJsonConverter),

            typeof(global::Vidu.JsonConverters.TaskStateJsonConverter),

            typeof(global::Vidu.JsonConverters.TaskStateNullableJsonConverter),

            typeof(global::Vidu.JsonConverters.TemplateToVideoRequestAspectRatioJsonConverter),

            typeof(global::Vidu.JsonConverters.TemplateToVideoRequestAspectRatioNullableJsonConverter),

            typeof(global::Vidu.JsonConverters.ReferenceToImageRequestModelJsonConverter),

            typeof(global::Vidu.JsonConverters.ReferenceToImageRequestModelNullableJsonConverter),

            typeof(global::Vidu.JsonConverters.ReferenceToImageRequestAspectRatioJsonConverter),

            typeof(global::Vidu.JsonConverters.ReferenceToImageRequestAspectRatioNullableJsonConverter),

            typeof(global::Vidu.JsonConverters.ReferenceToImageRequestResolutionJsonConverter),

            typeof(global::Vidu.JsonConverters.ReferenceToImageRequestResolutionNullableJsonConverter),

            typeof(global::Vidu.JsonConverters.UpscaleRequestResolutionJsonConverter),

            typeof(global::Vidu.JsonConverters.UpscaleRequestResolutionNullableJsonConverter),

            typeof(global::Vidu.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.Model), TypeInfoPropertyName = "Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.AspectRatio), TypeInfoPropertyName = "AspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.Resolution), TypeInfoPropertyName = "Resolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.MovementAmplitude), TypeInfoPropertyName = "MovementAmplitude2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.TaskState), TypeInfoPropertyName = "TaskState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.TextToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.ImageToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.ReferenceToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.StartEndToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.TemplateToVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.TemplateToVideoRequestAspectRatio), TypeInfoPropertyName = "TemplateToVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.LipSyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.ReferenceToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.ReferenceToImageRequestModel), TypeInfoPropertyName = "ReferenceToImageRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.ReferenceToImageRequestAspectRatio), TypeInfoPropertyName = "ReferenceToImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.ReferenceToImageRequestResolution), TypeInfoPropertyName = "ReferenceToImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.UpscaleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.UpscaleRequestResolution), TypeInfoPropertyName = "UpscaleRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.VideoTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.Creation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vidu.TaskCreations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vidu.Creation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vidu.Creation>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}