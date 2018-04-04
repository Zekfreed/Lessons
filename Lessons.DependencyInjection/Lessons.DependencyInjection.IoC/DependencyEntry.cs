using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.DependencyInjection.IoC
{
    public class DependencyEntry
    {
        public Type Abstract
        {
            get; set;
        }

        public Type Implementation
        {
            get; set;
        }

        
    }
}
