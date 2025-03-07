namespace Task4_4_NegativePower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введение исходных данных
            Console.Write("Введите положительное целое число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите отрицательное целое число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            //Верификация исходных данных
            if (a <= 0 || b >= 0)
            {
                Console.Write("Неверные исходные данные");
            }
            else
            {
                //Отрицательная степень - 1/a*a*a*...
                for (int i = 1; i <= (-b); i++)
                {
                    result *= a;
                }
                Console.Write($"{a} в степени {b} равно 1/{result}, что соответствует десятичной дроби: {Convert.ToDouble(1.0/result)}");
            }
            Console.ReadKey();
        }
    }
}
