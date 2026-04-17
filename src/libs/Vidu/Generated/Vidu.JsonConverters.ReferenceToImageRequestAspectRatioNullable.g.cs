#nullable enable

namespace Vidu.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReferenceToImageRequestAspectRatioNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vidu.ReferenceToImageRequestAspectRatio?>
    {
        /// <inheritdoc />
        public override global::Vidu.ReferenceToImageRequestAspectRatio? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Vidu.ReferenceToImageRequestAspectRatioExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vidu.ReferenceToImageRequestAspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vidu.ReferenceToImageRequestAspectRatio?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vidu.ReferenceToImageRequestAspectRatio? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vidu.ReferenceToImageRequestAspectRatioExtensions.ToValueString(value.Value));
            }
        }
    }
}
