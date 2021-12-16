#region
//Anton Manakov
/*4.Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
 * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля
 * тремя попытками.
    */
#endregion
using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;
            int count = 0;
            int maxTryes = 3;



            do
            {
                Console.WriteLine("\nВведите логин:");
                login = Console.ReadLine();

                #region
                /*if (login == "root")
                    Console.WriteLine("Логин успешно авторизован");
                else
                    Console.WriteLine("Логин некорректный");*/
                #endregion

                Console.WriteLine("\nВведите пароль");
                password = Console.ReadLine();

                #region
                /*if (password == "GeekBrains")
                    Console.WriteLine("Доступ разрешен");
                
                else
                    Console.WriteLine("В доступе отказано");*/
                #endregion
                count++;

                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine("Authorization Success");
                    return;

                }

                Console.WriteLine($"вам осталось {maxTryes - count} раза из трех");
            }
            while (count < maxTryes);
            Console.WriteLine("Authorization denied");
            Console.ReadLine();
        }
    }
}
#region
/*Console.WriteLine("\nВведите логин:");
            login = Console.ReadLine();
            Console.WriteLine("\nВведите пароль");
            password = Console.ReadLine();


            do
            {
                if (login != "root")
                if (password != "GeekBrains")
                    
                    Console.WriteLine("В доступе отказано");

                count++;

                
            }
            while (count < 3);

            Console.ReadLine();


*/
#endregion