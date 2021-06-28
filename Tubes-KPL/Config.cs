using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    class Config
    {
        public string user;
        public string pwd;

        public Config() { }

        public Config(string user, string pwd)
        {
            this.user = user;
            this.pwd = pwd;
        }
    }

    class uiConfig
    {
        private string pathDirectory = Environment.CurrentDirectory;
        private string loginPath = @"\login.json";

        public Config getConfig()
        {
            Config config = null;
            try
            {
                config = ReadFromJson<Config>(pathDirectory + loginPath);
            }
            catch
            {
                config = new Config("cypher", "corpse");
                SaveToJson<Config>(config, pathDirectory + loginPath);
            }
            return config;
        }

        public static T ReadFromJson<T>(String path)
        {
            string json = File.ReadAllText(path);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        public static void SaveToJson<T>(T obj, string path)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
