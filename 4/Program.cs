//Anton Manakov
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите числа");
            int n = int.Parse(Console.ReadLine());
            int sums = 0;

            while (n!=0) {
                
                if (n > 0 && n % 2!=0) {
                    //n = int.Parse(Console.ReadLine());
                    //sums = sums+ n;
                    sums += n;
                }
                n = int.Parse(Console.ReadLine());



            }
            Console.WriteLine(sums);

            Console.ReadLine();

        }
    }
}
