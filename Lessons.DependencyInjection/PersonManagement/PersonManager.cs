using Lesson.PersonPersistence.Json;
using Lessons.ReferencedClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.DependencyInjection.PersonManagement
{
    public class PersonManager
    {
        private readonly IPersonPersistenceService _service;
        public PersonManager(IPersonPersistenceService service)
        {
            _service = service;
        }
        public void LoadAndDisplayPerson(string jsonFilePath)
        {
            var person = _service.Load();

            person.DisplayMyProfession();
        }

        public void DisplyAndSave(IPerson person, string jsonFilePath)
        {
            person.DisplayMyProfession();
            _service.Save(person);
        }
    }
}
