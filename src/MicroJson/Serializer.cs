namespace MicroJson
{
    public class Serializer<T>
    {
        public T? Deserialize(string json) => default;
        public void Serialize(T @object, Stream output) { }
        public string Serialize(T @object) => "";
    }
}
