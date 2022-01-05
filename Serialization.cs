using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace AudioGame;

public static class Serialization
{
    private static BinaryFormatter formatter = new BinaryFormatter();

    public static string serialize(object obj)
    {
try
        {
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, obj);
                return Convert.ToBase64String(stream.ToArray());
            }
        }
        catch
        {
            return string.Empty;
        }
    }

    public static object deserialize_object(string data)
    {
        try
        {
            using (var stream = new MemoryStream(Convert.FromBase64String(data)))
            {
                return formatter.Deserialize(stream);
            }
        }
        catch
        {
            return new object();
        }
    }

}