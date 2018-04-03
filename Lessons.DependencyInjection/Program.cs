using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.DependencyInjection
{
    class Program
    {

        static void Main(string[] args)
        {
            IShape tr = new Triangle();

            var renderer1 = CreateRenderer(tr);

            IShape rect = new Rectangle();

            var renderer2 = CreateRenderer(rect);

            renderer1.RenderShape();

            renderer2.RenderShape();

            Console.ReadLine();
        }

        private static ShapeRenderer CreateRenderer(IShape shape)
        {
            return new ShapeRenderer(shape);
        }
    }
}
