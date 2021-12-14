using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа рассчитывает количество цифр \nВведите любое целое число: ");
            //Console.Write(Console.ReadLine().Length);
            int num = int.Parse(Console.ReadLine());
            int counter = 0;

            while (num != 0)
            {
                num = num / 10;
                counter++;
            }
            Console.WriteLine($"Количество цифр в числе равно: {counter}");
            Console.ReadLine();
        }


    }
}
