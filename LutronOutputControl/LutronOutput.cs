using System.Collections.Generic;
using System.Text.Json;

namespace LutronOutputControl
{
    public class LutronOutput
    {
        static Dictionary<string, int> loadDictionary = new Dictionary<string, int>();
        
        public static void GetLoadDictionary(string path)
        {
            string jsonString = System.IO.File.ReadAllText(path);
            loadDictionary = JsonSerializer.Deserialize<Dictionary<string, int>>(jsonString);
        }
        
        public static string Close(string loadName)
        {
            return $"#OUTPUT,{loadDictionary[loadName]},3";
        }
        
        public static string Open(string loadName)
        {
            return $"#OUTPUT,{loadDictionary[loadName]},2";
        }
        

    }
}