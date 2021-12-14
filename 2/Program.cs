using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш вес в килограммах: ");
            float ves = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в метрах");
            float rost = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш возраст (полных лет): ");
            int age = int.Parse(Console.ReadLine());

            float IMT = (float)ves / (rost * rost);                
            Console.WriteLine($"Индекс массы тела равен {IMT}");
            Console.WriteLine($"Ваш возраст: {age}");


            if (age <18) {
                Console.WriteLine("Ваш организм растущий, что не позволяет классифицировать ИМТ под статистические показатели");
            }
            else if (age >= 18 && age <= 25)
            {
                if (IMT < 18.5)
                    Console.WriteLine("У вас наблюдается недостаток массы тела");
                else if (IMT >= 20 && IMT <= 25)
                    Console.WriteLine("Ваш вес в норме");
                else if (IMT > 25 && IMT <= 30)
                    Console.WriteLine("У вас избыток веса");
                else if (IMT > 30 && IMT < 35)
                    Console.WriteLine("У вас склонность к ожирению, рекомендуется снизить вес");
                else
                    Console.WriteLine("У вас ожирение, необходимо срочно сбросить вес");

            }
            else {
                if (IMT < 20)
                    Console.WriteLine("У вас наблюдается недостаток массы тела");
                else if (IMT >= 20 && IMT <= 26)
                    Console.WriteLine("Ваш вес в норме");
                else if (IMT > 26 && IMT < 30)
                    Console.WriteLine("У вас избыток веса");
                else if (IMT >= 30 && IMT < 36)
                    Console.WriteLine("У вас склонность к ожирению, рекомендуется снизить вес");
                else
                    Console.WriteLine("У вас ожирение, необходимо срочно сбросить вес");

            }


            Console.ReadLine();
        }
    }
}
