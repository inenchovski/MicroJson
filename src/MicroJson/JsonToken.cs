namespace MicroJson;

internal struct JsonToken
{
    public Memory<char>  Text { get; }
    public JsonTokenKind Kind { get; }
}
