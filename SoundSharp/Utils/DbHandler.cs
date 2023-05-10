using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SoundSharp.Consts;

namespace SoundSharp.Utils
{
    internal class DbHandler<T>
    {
        private string _fileName;
        public string FileName { get { return _fileName; } }

        public DbHandler(string fileName)
        {
            _fileName = fileName;
        }

        public List<T> Get()
        {
            bool usersFileExist = File.Exists(FileName);
            if (!usersFileExist) File.Create(FileName).Close();

            List<T> result = Serialize();
            return result;
        }

        public void Add(T element)
        {
            List<T> elements = Get();
            elements.Add(element);
            string json = JsonSerializer.Serialize(elements);
            File.WriteAllText(FileName, json);
        }

        public List<T> Serialize()
        {
            List<T> result = new List<T>();
            string json = File.ReadAllText(FileName);
            try
            {
                result = JsonSerializer.Deserialize<List<T>>(json);
            }
            catch (JsonException)
            {

            }
            return result;
        }
    }
}
