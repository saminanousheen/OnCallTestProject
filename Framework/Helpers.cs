using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Helpers
{
    public class JSONHelper
    {

        public static Dictionary<string, object> ReadJsonFileAsDictionary(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonContent);
        }

        public static string GetValue(string key)
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\net6.0\", "");


            object value = "";
            string a = Directory.GetCurrentDirectory();
            var dataDictionary = ReadJsonFileAsDictionary(projectPath + @"\TestConfig.json");

            if (dataDictionary.TryGetValue(key, out value))
            {
                return (string)value;
            }
            return (string)value;
        }


    }
}
