using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ZappCash.packages.json
{
    //internal class json
    //{
    //}


    class jsonFile
    {
        //Initialize
        public jsonFile(string filePath)
        {
            jsonPath = filePath;
            read();

        }
        //Variables
        public dynamic jsonDeserialized { get; set; }
        public string jsonDeserializedText { get; set; }
        public string jsonPath { get; set; }
        public string jsonSerialized { get; set; }

        public string jsonPathSave { get; set; }
        public string jsonContent { get; set; }



        public void read()
        {
            jsonContent = File.ReadAllText(jsonPath);
            jsonDeserialized = JsonConvert.DeserializeObject(jsonContent);
        }

        public void write()
        {
            jsonSerialized = JsonConvert.SerializeObject(jsonDeserialized);
            File.WriteAllText(jsonPathSave, jsonSerialized);
        }

        public void ConvertToList()
        {
        }
    }


    public class json_controler
    {
        public string jsonFileLocation { get; set; }

        public void read()
        {
            //jsonDeserialized = JsonConvert.DeserializeObject(File.ReadAllText(jsonFileLocation));

        }
    }
}
