using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson.PersonPersistence.Json;
using Lessons.DependencyInjection.PersonManagement;
using Lessons.PersonPersistence.Xml;
using Lessons.ReferencedClassLibrary;
namespace Lessons.DependencyInjection
{
    class Program
    {

        static void Main(string[] args)
        {
            var setup = new Setup();
            setup.AddServices();
            //var service = new JsonPersonPersister("person.json");

            var service = setup.GetService<IPersonPersistenceService>(ConfigurationManager.AppSettings["Service"], ConfigurationManager.AppSettings["filePath"]);

            ManagePerson(service);
            Console.ReadLine();
        }

        private static void ManagePerson(IPersonPersistenceService service)
        {
            var manager = new PersonManager(service);

            manager.DisplyAndSave(new Student { FirstName = "Aschraf", LastName = "Layachi" }, "person.json");
        }

        private static void RenderShapes()
        {
            IShape tr = new Triangle();

            var renderer1 = CreateRenderer(tr);

            IShape rect = new Rectangle();

            var renderer2 = CreateRenderer(rect);

            renderer1.RenderShape();

            renderer2.RenderShape();


        }

        private static ShapeRenderer CreateRenderer(IShape shape)
        {
            return new ShapeRenderer(shape);
        }
    }
}
