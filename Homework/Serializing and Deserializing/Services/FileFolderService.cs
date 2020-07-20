using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services
{
    public class FileFolderService
    {
        private string _dirName = @"..\..\..\Data";
        private string _fileExtension;

        public FileFolderService(string fileExtension = "txt")
        {
            _fileExtension = fileExtension;
        }

        public void Write(string fileName, string content)
        {
            string fullPath = @$"{_dirName}\{fileName}.{_fileExtension}";
            FileStream file = OpenFile(fullPath, FileMode.Append);

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(content);
            }
        }

        public string Read(string fileName)
        {
            string fullPath = @$"{_dirName}\{fileName}.{_fileExtension}";
            FileStream file = OpenFile(fullPath, FileMode.Open);

            using (StreamReader reader = new StreamReader(file))
            {
                return reader.ReadToEnd();
            }
        }

        public void InsertToJSON<T>(T content)
        {
            string fileContentJson = Read(typeof(T).Name + "s");
            List<T> fileContent = JsonConvert.DeserializeObject<List<T>>(fileContentJson) ?? new List<T>();

            fileContent.Add(content);

            string fullPath = @$"{_dirName}\{typeof(T).Name}s.{_fileExtension}";
            FileStream file = OpenFile(fullPath, FileMode.Open);

            using (StreamWriter writer = new StreamWriter(file))
            {
                string newFileContentJson = JsonConvert.SerializeObject(fileContent);
                writer.Write(newFileContentJson);
            }
        }

        public IEnumerable<T> ReadJSON<T>()
        {
            string fullPath = @$"{_dirName}\{typeof(T).Name}s.{_fileExtension}";
            FileStream file = OpenFile(fullPath, FileMode.Open);

            using (StreamReader reader = new StreamReader(file))
            {
                return JsonConvert.DeserializeObject<List<T>>(reader.ReadToEnd());
            }
        }

        private FileStream OpenFile(string path, FileMode fileMode)
        {
            if (!File.Exists(path))
            {
                return File.Create(path);
            }

            return File.Open(path, fileMode);
        }
    }
}
