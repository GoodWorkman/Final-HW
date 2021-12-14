//Anton Manakov

using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа находит максимальное целое число из трех введенных");

            Console.Write("Введите первое число: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int third = int.Parse(Console.ReadLine());

            int max;

            if (first > second && first > third)
            {
                max = first;

                Console.WriteLine($"Максимальное число {max}");
            }
            else if (second > third)
                            {
                max = second;
                Console.WriteLine($"Максимальное число {max}");
            }
            else {
                max = third;
                Console.WriteLine($"Максимальное число {max}");
            }



            Console.ReadLine();
        }



    }
}
