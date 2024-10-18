using System;

namespace Lab_2._2_3
{
    public class Program
    {
        static void Main()
        {
            byte hor1 = Proverka.InputIntegerWithValidation($"Введите количество часов time1 (от 0 до 23)", 0, 23);
            byte min1 = Proverka.InputIntegerWithValidation($"Введите количество минут time1 (от  до 59)", 0, 59); 
            byte hor2 = Proverka.InputIntegerWithValidation($"Введите количество часов time2 (от  до 23)", 0, 23); 
            byte min2 = Proverka.InputIntegerWithValidation($"Введите количество минут time1 (от  до 59)", 0, 59); 

            Time time1 = new Time(hor1, min1); 
            Time time2 = new Time(hor2, min2); 

            Time result = time1.Subtract(time2);

            Console.WriteLine($"Результат вычитания: {result}"); // Вывод результата
            //унарные операции
            Time nullTime = ~time1;
            Console.WriteLine($"Обнуление минут time1-> {nullTime}");
            Time nullMinutes = time2.NullMinutes();
            Console.WriteLine($"Обнуление минут time2 -> {nullMinutes}");

            //приведение к типу bool
            bool hours = (bool)time1;
            Console.WriteLine($"Часы Time1 -> {hours}");
            bool notNull = (bool)time1;
            Console.WriteLine($"Time1 не нулевое? {notNull}");

            //бинарные операции
            bool rovn = time1 == time2;
            Console.WriteLine($"time1 ({time1}) == time2 ({time1})? {rovn}"); // Вывод: False

            bool notRovn = time1 != time2;
            Console.WriteLine($"time1 ({time1}) != time2 ({time2})? {notRovn}"); // Вывод: True
        }
    }
}
