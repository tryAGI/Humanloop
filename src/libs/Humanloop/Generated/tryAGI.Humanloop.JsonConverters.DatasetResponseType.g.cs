#nullable enable

namespace tryAGI.Humanloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class DatasetResponseTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.Humanloop.DatasetResponseType>
    {
        /// <inheritdoc />
        public override global::tryAGI.Humanloop.DatasetResponseType Read(
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
                        return global::tryAGI.Humanloop.DatasetResponseTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.Humanloop.DatasetResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.Humanloop.DatasetResponseType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.Humanloop.DatasetResponseType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::tryAGI.Humanloop.DatasetResponseTypeExtensions.ToValueString(value));
        }
    }
}
