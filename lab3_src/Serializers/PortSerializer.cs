using lab3_src.Models.Port;
using System.IO;
using System.Text.Json;

namespace lab3_src.Serializers;
public static class PortSerializer
{
    public static void Serialize(Port port)
    {
        try
        {
            if (!Directory.Exists("Save\\")) Directory.CreateDirectory("Save\\");

            File.WriteAllText($"Save\\{port.Name}.json", JsonSerializer.Serialize(port));
        }
        catch(Exception)
        {

        }
    }

    public static Port? Deserialize(string filename)
    {
        try
        {
            using (var fileStream = new FileStream(filename, FileMode.Open))
            {
                return JsonSerializer.Deserialize<Port>(fileStream);
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
