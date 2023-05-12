﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundSharp.Consts;

namespace SoundSharp.Utils
{
    internal class DbHandler<T>
    {
        private string _fileName;
        private string _idFile;
        public string FileName { get { return _fileName; } }
        public string IdFile { get { return _idFile; } }

        public DbHandler(string fileName, string idFile)
        {
            _fileName = fileName;
            _idFile = idFile;
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

        public int GetNewId()
        {
            if (!File.Exists(IdFile))
            {
                string value = "1";
                File.WriteAllText(IdFile, value);
                return 1;
            }

            int prevId = int.Parse(GetLastId());
            int newId = prevId + 1;
            string newIdString = newId.ToString();
            MessageBox.Show(newIdString);
            File.WriteAllText(IdFile, newIdString);
            return newId;
        }

        public string GetLastId()
        {
            StreamReader sr = new StreamReader(IdFile);
            //Read the first line of text
            string line = sr.ReadLine();
            sr.Close();
            return line;
        }
    }
}