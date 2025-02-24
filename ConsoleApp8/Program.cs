using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /// <summary>
    /// Заполнить одномерный массив, используя явную инициализацию, и вывести индексы элементов, больших заданного числа.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 5, 8, 12, 3, 7, 9, 2 };
            int num = 5;
            For(mas, num);

            Console.ReadLine();
        }

        static void For(int[] mas, int num)
        {
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] > num)
                    {
                        Console.WriteLine($"mas{i} = {mas[i]} > {num}");
                    }
                }
            }
        }
    }
}
