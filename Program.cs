using System;

namespace Semenar6_CSharp_Start
{
    class Program
    {
        

        static void Main(string[] args)
        {
            /*
            Задача 41: Пользователь вводит с клавиатуры M чисел.
            Посчитайте, сколько чисел больше 0 ввёл пользователь.
            0, 7, 8, -2, -2 -> 2
            -1, -7, 567, 89, 223-> 3
            Задача 43: Напишите программу, которая найдёт точку
            пересечения двух прямых, заданных уравнениями y = k1 *
            x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
            пользователем.
            b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
            */


            // Задача 41:
            

            Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. " +
                    "Посчитайте, сколько чисел больше 0 ввёл пользователь.");

            Console.WriteLine("Введите число М:");
            

            
            bool numberCheck = int.TryParse(Console.ReadLine(), out int numberM);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число.");
                Console.WriteLine("Введите число М:");
                numberCheck = int.TryParse(Console.ReadLine(), out numberM);
            }

            // считано число элементов М

            int task41 = 0;
            int[] arr = new int[numberM];

            for(int i = 0; i < numberM; i++) { 

            
                Console.WriteLine("Введите " + i+1 + "-ное число:");
                numberCheck = int.TryParse(Console.ReadLine(), out arr[i]);
                while (!numberCheck)
                {
                    Console.WriteLine("Введено не число.");
                    Console.WriteLine("Введите " + i+1 + "-ное число:");
                    numberCheck = int.TryParse(Console.ReadLine(), out arr[i]);
                }

                // считан i-тый элемент в массив

                if (arr[i] > 0)
                    task41++;

            }


            
            Console.WriteLine(task41);
            Console.WriteLine("\n");

            
            // Задача 43:
            

            Console.WriteLine("Задача 43. Напишите программу, которая найдёт точку " +
                "пересечения двух прямых, заданных уравнениями y = k1 * " +
                "x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");

            Console.WriteLine("Введите b1, затем k1, затем b2, затем k2 элементов в массиве:");

            // b1

            Console.WriteLine("Введите b1");
            numberCheck = double.TryParse(Console.ReadLine(), out double task43_b1);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = double.TryParse(Console.ReadLine(), out task43_b1);
            }

            // k1

            Console.WriteLine("Введите k1");
            numberCheck = double.TryParse(Console.ReadLine(), out double task43_k1);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = double.TryParse(Console.ReadLine(), out task43_k1);
            }

            // b2

            Console.WriteLine("Введите b2");
            numberCheck = double.TryParse(Console.ReadLine(), out double task43_b2);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = double.TryParse(Console.ReadLine(), out task43_b2);
            }

            // k2

            Console.WriteLine("Введите k2");
            numberCheck = double.TryParse(Console.ReadLine(), out double task43_k2);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = double.TryParse(Console.ReadLine(), out task43_k2);
            }


            /*
             y1 = k1 * x1 + b1;
             y2 = k2 * x2 + b2;
             * 
             Условие: y1 = y2; x1 = x2 Следовательно:
             
             y = k1 * x + b1;
             y = k2 * x + b2; 
             k1 * x + b1 = k2 * x + b2
             x = (b2 - b1) / (k1 - k2)  (эквивалентно x = (b1 - b2) / (k2 - k1) )
               y = x * k1 + b1;
             */

            double task43_x = (task43_b2 - task43_b1) / (task43_k1 - task43_k2);
            double task43_y = task43_x * task43_k1 + task43_b1;

            Console.Out.WriteLine("у = " + task43_x + "*" + task43_k1 + " + " + task43_b1);
            Console.Out.WriteLine("(" + task43_x + "; " + task43_y + ")");

        }
    }
}

