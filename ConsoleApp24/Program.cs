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

                int[] array = new int[] { 5, 12, 3, 44, 1, 6 };
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Элемент неотсортированного массива [" + i + "]:" + array[i] + ";");
                }
                Console.WriteLine("\n");

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }

                    Console.WriteLine("Элемент отсортированного массива [" + i + "]:" + array[i] + ";");
                }

                Console.ReadLine();

            }
        }
    }
}
    
