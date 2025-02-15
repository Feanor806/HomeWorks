namespace Task2_6_AccuracyRound
{
    internal class Program
    {
        //Округление длины трубы в метрах с арифметической точностью до 0,5 м
        static void Main(string[] args)
        {
            //Получаем длину трубы в м
            Console.Write("Укажите длину трубы (в метрах): ");
            double pipeLength = Math.Abs(Convert.ToDouble(Console.ReadLine()));

            //Округляем значение с точностью до 0.5 метра
            pipeLength = Math.Round(pipeLength / 0.5, 0) * 0.5;

            //Выводим результат
            Console.WriteLine($"Длина трубы составляет: {pipeLength} метров");
            Console.WriteLine($"Нажмите любую кнопку для завершения.");
            Console.ReadKey();
        }
    }
}
