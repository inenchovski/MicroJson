namespace MicroJson;

internal enum JsonTokenKind
{
    Object = 0x1,
    Array = 0x2,
    String = 0x4,
    Number = 0x8,
    True = 0x10,
    False = 0x20,
    Null = 0x40,
    KeyName = 0x80,
}
