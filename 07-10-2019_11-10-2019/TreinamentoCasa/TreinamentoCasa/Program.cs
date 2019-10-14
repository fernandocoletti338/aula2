using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoCasa
{
    class Program
    {

        static void Main(string[] args)
        {
            var names = new List<string>() { "Nando", "Sheila", "Gabriel" };

            foreach (string name in names)
            {
                if (name == "Sheila")
                {
                    break;
                }
                Console.WriteLine(name);

            }
            Console.WriteLine("ok");
        }
    }
}
