namespace Task4_8_MirroringNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод исходных данных
            Console.Write("Введите целое число для отзеркаливания: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int countDigits = 0;
            int result = 0;

            //Определение числа разрядов
            do
            {
                countDigits++;
            } while (number / Math.Pow(10, countDigits) >= 1);

            //Перестановка символов
            for (int i = 0; i < countDigits; i++)
            {
                result += (number % (int)Math.Pow(10, i + 1)) / (int)Math.Pow(10, i) * (int)(Math.Pow(10, (countDigits - 1 - i)));
            }
            Console.WriteLine($"Результат перестановки: {result}");
        }
    }
}
