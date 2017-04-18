using System;

namespace Task3
{ 
    class Program
    {
        static void Main()
        {
            var number = 0;
            var ok = true;
            double result = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите действительное число а");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number <= -1) result = 1 / Math.Pow(number, 2);
                    else if (number > -1 && number < 2) result = Math.Pow(number, 2);
                    else result = 4;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка при вводе числа");
                    ok = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка при вводе числа");
                    ok = false;
                }
            } while (!ok);
            Console.WriteLine("Значение функции в точке {0} равно {1}", number, result);
        }
    }
}
