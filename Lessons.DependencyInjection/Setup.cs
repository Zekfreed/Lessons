using Lesson.PersonPersistence.Json;
using Lessons.DependencyInjection.IoC;
using Lessons.PersonPersistence.Xml;
using Lessons.ReferencedClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.DependencyInjection
{
    public class Setup
    {

        private readonly DependencyRegistry _container;
        public Setup()
        {
            _container = new DependencyRegistry();
        }
        public void AddServices()
        {
            _container.Register<IPersonPersistenceService, JsonPersonPersister>("JsonService");
            _container.Register<IPersonPersistenceService, XmlPersonPersister>("XmlService");
        }

        public TAbstract GetService<TAbstract>(string uniqueName, params object[] args)
        {

            return _container.Resolve<TAbstract>(uniqueName, args);
        }
    }
}
