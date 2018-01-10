using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using com.miaow.Core.Domain.Entities;
using com.miaow.Model;

namespace com.miaow.App.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var assembly = Assembly.LoadFile(@"F:\GithubRepository\com.miaow\References\com.miaow.Model.dll");
            var modelTypes = assembly.GetTypes().ToList();
            var modelInterface = typeof(IEntity);

            var assemblys = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => x.Name.EndsWith("Model") && modelInterface.IsAssignableFrom(x))
                .ToList();
            
            foreach (Type type in assemblys.Where(x => modelInterface.IsAssignableFrom(x) && x.Name.EndsWith("Model")))
            {
                var typeName = type.Name;
                var serviceName = typeName.Substring(0, typeName.Length - 5);
                Console.WriteLine(serviceName);
            }

        }
    }
}
