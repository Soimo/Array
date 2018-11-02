using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Пример работы с массивами \n");
            Console.WriteLine("\nВведите длинну строки (натуральное число)\n");
            int x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nВведите длинну столбца (натуральное число)\n");
            int y = int.Parse(Console.ReadLine());

            int[,] arr1 = new int[x, y];

            Console.WriteLine("\nЗаполните таблицу первого массива\n");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("Индекс[" + i + "," + j + "]: ");
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            

            int[,] arr2 = new int[x, y];

            Console.WriteLine("\nЗаполните таблицу второго массива\n");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("Индекс[" + i + "," + j + "]: ");
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] arr3 = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }

            }

            Console.WriteLine("\nСумма массивов:\n");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("Значение массива с индексом [ " + i + "," + j + " ] равно: " + arr3[i,j]);

                }
            }
            Console.ReadLine();
        }


        
    }
}
