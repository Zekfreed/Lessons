using Lessons.ReferencedClassLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.PersonPersistence.Json
{
    public class JsonPersonPersister : IPersonPersistenceService
    {
        private readonly string _jsonFilePath;
        public JsonPersonPersister(string jsonFilePath)
        {
            _jsonFilePath = jsonFilePath;
        }
        public IPerson Load()
        {
            var json = File.ReadAllText(_jsonFilePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                throw new ArgumentNullException($"the file {_jsonFilePath} do not contains a valid json!");
            }

            return (IPerson)JsonConvert.DeserializeObject(json);
        }

        public void Save(IPerson person)
        {
            var json = JsonConvert.SerializeObject(person);

            File.WriteAllText(_jsonFilePath, json);
        }
    }
}
