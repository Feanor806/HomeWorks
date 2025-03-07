namespace Task4_7_CountDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод исходных данных
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int countDigits = 0;

            do
            {
                countDigits++;
            } while (number/Math.Pow(10,countDigits) >= 1);

            Console.WriteLine($"Число цифр в составе числа {number}: {countDigits}");
            Console.ReadKey();
        }
    }
}
