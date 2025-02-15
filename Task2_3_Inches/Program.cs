namespace Task2_3_Inches
{
    internal class Program
    {
        /// <summary>
        /// Перевод длины участка трубы из дюймов в метры, сантиметры и миллиметры
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Объявление переменных. В качестве десятичных единиц используются миллиметры
            const double inch = 25.4;
            double pipeLengthMetric;
            uint meters;
            byte santimeters;
            byte milimeters;

            //Получение длины трубы в дюймах
            Console.Write("Введите длину трубы в дюймах: ");
            double pipeLengthInches = Convert.ToDouble(Console.ReadLine());

            //Перевод лины трубы в метрическую систему
            pipeLengthMetric = pipeLengthInches * inch;

            //Получение метров, сантиметров и миллиметров
            meters = (uint)Math.Floor(pipeLengthMetric / 1000);
            santimeters = (byte)Math.Floor((pipeLengthMetric - meters*1000)/ 10);
            milimeters = (byte)Math.Round(pipeLengthMetric - meters * 1000 - santimeters*10);

            //Выведение результата
            Console.WriteLine($"Длина участка трубы составляет {meters} м {santimeters} см {milimeters} мм ");
            Console.WriteLine($"Нажмите любую кнопку для завершения.");
            Console.ReadKey();
        }
    }
}
