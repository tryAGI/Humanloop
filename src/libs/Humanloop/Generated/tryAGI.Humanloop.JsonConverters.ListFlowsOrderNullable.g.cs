#nullable enable

namespace tryAGI.Humanloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListFlowsOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.Humanloop.ListFlowsOrder?>
    {
        /// <inheritdoc />
        public override global::tryAGI.Humanloop.ListFlowsOrder? Read(
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
                        return global::tryAGI.Humanloop.ListFlowsOrderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.Humanloop.ListFlowsOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.Humanloop.ListFlowsOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.Humanloop.ListFlowsOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.Humanloop.ListFlowsOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
