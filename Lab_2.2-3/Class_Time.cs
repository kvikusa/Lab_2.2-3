using System;

namespace Lab_2._2_3
{
    class Time
    {
        // поля
        byte hours;
        byte minutes;

        //аксессоры
        public byte Hours
        {
            get => hours; 
            set => hours = value;
                     
        }
        public byte Minutes
        {
            get => minutes;
            set => minutes = value;
        }

        public Time (byte hours, byte minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        // Метод для вычитания времени
        public Time Subtract(Time other)
        {
            int min_1 = hours * 60 + minutes; // Конвертация текущего времени в минуты
            int min_2 = other.hours * 60 + other.minutes; // Конвертация времени для вычитания в минуты

            int diff = min_1 - min_2; // Вычисление разницы в минутах

            // Если разница отрицательная, то добавляем 1440 минут (24 часа)
            if (diff < 0)
            {
                diff += 1440; // 24 часа в минутах
            }

            // Возвращаем результат как объект Time
            return new Time((byte)(diff / 60), (byte)(diff % 60));
        }

        // Переопределение метода ToString для удобного отображения времени
        public override string ToString()
        {
            return $"{hours:D2}:{minutes:D2}"; // Форматирование в виде "hh:mm"
        }

        //3 ЗАДАЧА
        // Унарные операции
        public static Time operator ~(Time time) //обнуление часов и минут
        {
            return new Time(0, 0);
        }
        public Time NullMinutes() //обнуление минут
        {
            return new Time(this.hours, 0);
        }

        //приведение типов
        public static implicit operator byte(Time time) //неявное приведение к типу byte кол-во часов
        {
            return time.hours; // Возвращаем только часы
        }
        public static explicit operator bool(Time time) // явное приведение к типу bool
        {
            return time.hours != 0 || time.minutes != 0; // true, если хотя бы одно из значений не равно нулю
        }

        //бинарные операции
        public static bool operator ==(Time t1, Time t2) //операция ==
        {
            // Проверка на null
            if (ReferenceEquals(t1, t2)) return true;
            if (ReferenceEquals(t1, null) || ReferenceEquals(t2, null)) return false;

            return t1.hours == t2.hours && t1.minutes == t2.minutes; // Сравниваем часы и минуты
        }
        public static bool operator !=(Time t1, Time t2) //операция неравенства
        {
            return !(t1 == t2); // Используем оператор равенства
        }

    }
}
