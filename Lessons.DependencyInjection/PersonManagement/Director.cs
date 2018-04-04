using Lessons.ReferencedClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.DependencyInjection.PersonManagement
{
    public class Director : IPerson
    {
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get;
            set;
        }

        public void DisplayMyProfession()
        {
            Console.WriteLine($"hello I am {FirstName}, {LastName} and I am a director!");
        }
    }
}
