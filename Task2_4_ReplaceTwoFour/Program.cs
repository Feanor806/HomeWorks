using System.Diagnostics.Metrics;

namespace Task2_4_ReplaceTwoFour
{
    internal class Program
    {
        /// <summary>
        /// Перестановка 2 и 4 члена для четырехзначного числа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //объявляение переменных
            byte first;
            byte second;
            byte third;
            byte fourth;

            //Получение числа от пользователя
            Console.Write("Введите четырехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //Получение элементов числа
            first = (byte)(number / 1000);
            second = (byte)(number % 1000 / 100);
            third = (byte)(number % 100 / 10);
            fourth = (byte)(number % 10);

            //Перестановка элементов 2 и 4
            fourth = (byte)(fourth + second);
            second = (byte)(fourth - second);
            fourth = (byte)(fourth - second);

            //Получение нового числа
            number = first * 1000 + second * 100 + third * 10 + fourth;

            //Выведение результата
            Console.WriteLine($"Новое число с переставленным 2 и 4 членом: {number}");
            Console.WriteLine($"Нажмите любую кнопку для завершения.");
            Console.ReadKey();
        }
    }
}
