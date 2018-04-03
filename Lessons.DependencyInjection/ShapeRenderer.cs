using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.DependencyInjection
{
    public class ShapeRenderer
    {
        private readonly IShape _shape;
        public ShapeRenderer(IShape shape)
        {
            _shape = shape;
        }


        public void RenderShape()
        {
            _shape.Display();
        }
    }
}
