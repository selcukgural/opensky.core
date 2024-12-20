using System.Text.Json;
using System.Text.Json.Serialization;

namespace OSS.Core.Converter;

/// <summary>
/// Converts JSON string values to boolean objects and vice versa.
/// </summary>
internal sealed class JsonStringToBooleanConverter : JsonConverter<bool>
{
    /// <summary>
    /// Reads and converts the JSON string to a boolean object.
    /// </summary>
    /// <param name="reader">The reader to read the JSON from.</param>
    /// <param name="typeToConvert">The type to convert.</param>
    /// <param name="options">Options to control the conversion behavior.</param>
    /// <returns>The converted boolean object.</returns>
    /// <exception cref="JsonException">Thrown when the JSON token type is not a string or the string cannot be converted to boolean.</exception>
    public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException("Invalid token type for boolean conversion.");
        }

        var stringValue = reader.GetString();

        if (bool.TryParse(stringValue, out var result))
        {
            return result;
        }

        throw new JsonException($"Unable to convert '{stringValue}' to boolean.");
    }

    /// <summary>
    /// Writes a boolean object as a JSON string.
    /// </summary>
    /// <param name="writer">The writer to write the JSON to.</param>
    /// <param name="value">The boolean value to convert.</param>
    /// <param name="options">Options to control the conversion behavior.</param>
    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}