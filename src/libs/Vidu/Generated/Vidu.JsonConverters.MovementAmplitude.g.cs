#nullable enable

namespace Vidu.JsonConverters
{
    /// <inheritdoc />
    public sealed class MovementAmplitudeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vidu.MovementAmplitude>
    {
        /// <inheritdoc />
        public override global::Vidu.MovementAmplitude Read(
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
                        return global::Vidu.MovementAmplitudeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vidu.MovementAmplitude)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vidu.MovementAmplitude);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vidu.MovementAmplitude value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vidu.MovementAmplitudeExtensions.ToValueString(value));
        }
    }
}
