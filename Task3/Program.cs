using System;
using static System.Console;

namespace Task3
{ 
    class Program
    {
        public static bool Exit() // выход из программы
        {
            WriteLine("Желаете начать сначала или нет? \nВведите да или нет");
            var word = Convert.ToString(ReadLine()); // ответ пользователя
            Clear();
            if (word == "да" || word == "Да" || word == "ДА")
            {
                Clear();
                return false;
            }
            Clear();
            WriteLine("Вы ввели 'нет' или что-то непонятное. Нажмите любую клавишу, чтобы выйти из программы.");
            ReadKey();
            return true;
        }

        static void Main()
        {
            bool okay;
            do
            {
                var number = 0; // переменная для числа
                var ok = true; // переменная для определения корректности ввода
                double result = 0; // переменная для результата вычислений
                do
                {
                    try
                    {
                        WriteLine("Введите действительное число а");
                        number = Convert.ToInt32(ReadLine());
                        ok = true;
                        if (number <= -1) result = 1 / Math.Pow(number, 2); // проверка того, в какой диапазон входит число 
                        else if (number > -1 && number < 2) result = Math.Pow(number, 2);
                        else result = 4;
                    }
                    catch (FormatException)
                    {
                        WriteLine("Ошибка при вводе числа");
                        ok = false;
                    }
                    catch (OverflowException)
                    {
                        WriteLine("Ошибка при вводе числа");
                        ok = false;
                    }
                } while (!ok);
                WriteLine("Значение функции в точке {0} равно {1}", number, result); // вывод результата
                okay = Exit(); // выход из программы
            } while (!okay);
        }
    }
}
