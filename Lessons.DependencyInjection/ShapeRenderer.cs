using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.DependencyInjection
{
    public class ShapeRenderer
    {


        public void RenderShape()
        {
            var rect = new Rectangle();
            rect.Display();
        }
    }
}
