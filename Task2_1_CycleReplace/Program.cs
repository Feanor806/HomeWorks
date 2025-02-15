using System.Threading.Channels;

namespace Task2_1_CycleReplace
{
    internal class Program
    {
        /// <summary>
        /// Цикличная перестановка значений трех переменных a,b,c
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ПОлучаем значения от пользователя
            Console.Write("Введите значение числа a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение числа b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение числа c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            //Меняем местами C и B
            c = c + b;
            b = c - b;
            c -= b;

            //Меняем местами A и B
            b = a + b;
            a = b - a;
            b -= a;

            //Выводим результат
            Console.WriteLine($"Значения переставлены: {a} : {b} : {c}");
            Console.WriteLine($"Нажмите любую кнопку для завершения.");
            Console.ReadKey();
        }
    }
}
