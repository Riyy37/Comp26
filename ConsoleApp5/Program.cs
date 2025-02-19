using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /// <summary>
    /// Заполнить одномерный массив из n элементов с клавиатуры и вывести его на экран.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {            
            int[] mas = Input();
            Output(mas);
            Console.ReadKey();
        }

        static int[] Input()
        {
            int[] mas = new int[5];
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"mas[{i}]: ");
                mas[i] = int.Parse(Console.ReadLine());
            }
            return mas;
        } 
        static void Output(int[]mas)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{mas[i]} \t");
            }
        }

    }
}
