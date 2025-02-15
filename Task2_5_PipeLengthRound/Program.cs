using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2_5_PipeLengthRound
{
    internal class Program
    {
        /// <summary>
        /// Округление длины трубы в метрах до целого в большую сторону
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Получение длины трубы в метрах
            Console.Write("Укажите длину трубы (в метрах): ");
            uint pipeLength = (uint)Math.Ceiling(Math.Abs(Convert.ToDouble(Console.ReadLine())));

            //Вывод результата
            Console.WriteLine($"Длина трубы составляет: {pipeLength} метров");
            Console.WriteLine($"Нажмите любую кнопку для завершения.");
            Console.ReadKey();
        }
    }
}
