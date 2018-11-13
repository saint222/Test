using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                
                List<string> names = new List<string> {"Bob", "555", "Alex"};
                names.Sort();
                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine(names [i]);
                }
                Console.WriteLine("Hello Git");
                //learning to commit
                Console.ReadLine();
            }
        }
    }
}
