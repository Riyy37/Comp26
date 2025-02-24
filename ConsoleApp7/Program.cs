using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /// <summary>
    /// Заполнить одномерный массив соответствующими индексами и вывести с использованием цикла foreach.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            int[] mas = new int[10];

            Foreach(mas);

        }
        static void Foreach(int[] mas)
        {
            For(mas);
            foreach (int value in mas)
            {
                Console.WriteLine(value);
            }
        }
        static void For(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = i;
            }
        }
    }
}
