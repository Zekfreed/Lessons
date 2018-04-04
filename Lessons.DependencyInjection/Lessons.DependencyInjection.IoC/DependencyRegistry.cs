using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.DependencyInjection.IoC
{
    public class DependencyRegistry
    {
        private readonly Dictionary<string, DependencyEntry> _container;
        public DependencyRegistry()
        {
            _container = new Dictionary<string, DependencyEntry>();
        }
        public void Register<TAbstract, TImplementation>(string uniqueName)
            where TImplementation : TAbstract
        {

            _container.Add(uniqueName, new DependencyEntry { Abstract = typeof(TAbstract), Implementation = typeof(TImplementation) });
        }

        public Tabstract Resolve<Tabstract>(string uniquename)
        {
            return (Tabstract)Activator.CreateInstance(typeof(Tabstract));
        }

        public Tabstract Resolve<Tabstract>(string uniquename, params object[] args)
        {
            var type = _container[uniquename].Implementation;
            return (Tabstract)Activator.CreateInstance(type, args);
        }

    }
}
