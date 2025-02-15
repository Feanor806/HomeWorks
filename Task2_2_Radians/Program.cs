namespace Task2_2_Radians
{
    internal class Program
    {
        /// <summary>
        /// Перевод величины угла в градусах, минутах и секундах в радианы. Вычисление эквивалентного угла для значений свыше 360.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Объявление переменных
            double radians; //Переменная для вывода результата в радианах
            double decimalDegrees; //Переменная для перевода величины угла в десятичную систему
            sbyte sign; //Переменная для определения знака значения в градусах

            //Получение данных от пользователя
            Console.Write("Введите количество градусов: ");
            int degrees = Convert.ToInt32(Console.ReadLine());
            sign = (sbyte)(degrees / Math.Abs(degrees));
            Console.Write("Введите количество минут: ");
            byte minutes = (byte)Math.Abs(Convert.ToSByte(Console.ReadLine()));
            Console.Write("Введите количество секунд: ");
            byte seconds = (byte)Math.Abs(Convert.ToSByte(Console.ReadLine()));

            Console.WriteLine($"Введен угол {degrees} град. {minutes}\' {seconds}\" ");

            //Приводим число градусов к положительному
            degrees = Math.Abs(degrees);

            //Перевод градусов минут и секунд в десятичное значение. Углы более 360 градусов приводятся к значениям от 0 до 360.
            decimalDegrees = (double)(degrees + (double)minutes / 60 + (double)seconds / 3600) % 360;

            //Вычисление значения угла в радианах c округлением до 5 знаков
            radians = Math.Round(decimalDegrees * Math.PI / 180, 5) * sign;

            //Вычисление эквивалентного угла (для углов более 360 градусов и для значений минут и секунд более 60)
            degrees = (int)Math.Floor(decimalDegrees);
            minutes = (byte)Math.Floor((decimalDegrees - degrees)*60);
            seconds = (byte)((decimalDegrees - degrees - (double)minutes/60) * 3600);

            //Добавляем знак к значению угла
            degrees = degrees * sign;

            //Привести значение отрицательного угла к диапазону 0...360 не получится без операции сравнения

            //Вывод величины углв в радианах и вывод эквивалентного угла (для углов более 360 град)
            Console.WriteLine($"Величина указанного угла в радианах: {radians}");
            Console.WriteLine($"Эквивалентный угол {degrees} град. {minutes}\' {seconds}\" ");
            Console.WriteLine($"Нажмите любую кнопку для завершения.");
            Console.ReadKey();
        }
    }
}
