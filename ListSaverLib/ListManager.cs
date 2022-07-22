using System.Collections;
using System.Text.Json;

namespace ListManagerLib
{
    public class ListManager
    {
        public static void SaveList<T>(string path, List<T> list)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, list);
                Console.WriteLine("Success");
            }
        }
        public static void SaveList(string path, ArrayList list)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, list);
                Console.WriteLine("Success");
            }
        }

        public static List<T> LoadList<T>(string path)
        {
            if(File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    return JsonSerializer.Deserialize<List<T>>(fs);
                }
            }
            return null;
            
        }

        public static ArrayList LoadList(string path)
        {
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    return JsonSerializer.Deserialize<ArrayList>(fs);
                }
            }
            return null;

        }
    }
}