using Lessons.ReferencedClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Lessons.PersonPersistence.Xml
{
    public class XmlPersonPersister : IPersonPersistenceService
    {
        private readonly string _xmlFilePath;
        public XmlPersonPersister(string filePath)
        {
            _xmlFilePath = filePath;
        }
        public IPerson Load()
        {
            var xs = new XmlSerializer(typeof(IPerson));

            using (var sr = new StreamReader(_xmlFilePath))
            {
                return (IPerson)xs.Deserialize(sr);
            }
        }

        public void Save(IPerson person)
        {
            var xs = new XmlSerializer(person.GetType());
            using (var sw = new StreamWriter(_xmlFilePath))
            {
                xs.Serialize(sw, person);
            }
        }
    }
}
