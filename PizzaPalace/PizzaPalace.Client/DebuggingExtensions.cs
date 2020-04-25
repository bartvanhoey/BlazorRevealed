using static System.Text.Json.JsonSerializer;

namespace PizzaPalace.Client
{
    public static class DebuggingExtensions
    {
        public static string ToJson(this object obj) => Serialize(obj);
    }
}