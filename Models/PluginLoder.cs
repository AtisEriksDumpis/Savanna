using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace models
{
    public class PluginLoder
    {
        public static List<IAnimal> Plugins { get; set; }
        public void LoadPlugins()
        {
            constants constants = new constants();
            Plugins = new List<IAnimal>();
            if (Directory.Exists(constants.path))
            {
                string[] files = Directory.GetFiles(constants.path, constants.dllFile);
                foreach (string file in files)
                {
                    if (file.EndsWith(".dll"))
                    {
                        Assembly.LoadFile(Path.GetFullPath(file));
                    }
                }
            }
            Type interfaceType = typeof(IAnimal);
            Type[] types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass)
                .ToArray();
            foreach (Type type in types)
            {
                Plugins.Add((IAnimal)Activator.CreateInstance(type));
            }
        }
    }
    
}
