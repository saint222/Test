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

                Console.WriteLine("Создадим массив!" + "\n" + "Введите количество элементов массива!");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Random value = new Random();
                Console.WriteLine("Значения элементам массива присвоены случайным образом в диапазоне от -100 до 100.");
                Console.WriteLine("Значения элементов массива следующие:");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = value.Next(-100, 100);
                    Console.WriteLine(array[i]);
                }
                Console.WriteLine("Найдем минимальное значение элементов получившегося массива.");
                int min = int.MaxValue;

                for (int i = 0; i < array.Length; i++)
                {
                    if (min > array[i])
                    {
                        min = array[i];
                    }
                }
                Console.WriteLine("\nМинимальное значение элементов получившегося массива-" + " " + min + ";");
                int max = int.MinValue;
                for (int i = 0; i < array.Length; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                    }
                }
                Console.WriteLine("\nМаксимальное значение элементов получившегося массива-" + " " + max + ";");
                Console.Beep();
            }
            Console.ReadLine();

        }
    }
}
 
