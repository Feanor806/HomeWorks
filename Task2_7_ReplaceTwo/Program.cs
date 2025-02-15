namespace Task2_7_ReplaceTwo
{
    internal class Program
    {
        /// <summary>
        /// Перестановка значений двух переменных без использования дополнительной переменной
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Получение значений переменных
            Console.Write("Введите значение A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            //Перестановка переменных
            b = a + b;
            a = b - a;
            b -= a;

            //Выводим результат
            //Выводим результат
            Console.WriteLine($"Переменные переставлены: {a} : {b}");
            Console.WriteLine($"Нажмите любую кнопку для завершения.");
            Console.ReadKey();
        }
    }
}
