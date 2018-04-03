using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.DependencyInjection
{
    public class Triangle : IShape
    {
        public void Display()
        {
            Console.WriteLine("triangle");
        }
    }
}
