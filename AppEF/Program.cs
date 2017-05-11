using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();

            var categorias = manager.ListAll().ToList();

            foreach (var c in categorias)
            {
                Console.WriteLine(c.Nome);
            }
            Console.ReadKey();
        }
    }
}
