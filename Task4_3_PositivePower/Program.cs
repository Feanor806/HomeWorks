namespace Task4_3_PositivePower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введение исходных данных
            Console.Write("Введите положительное целое число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите положительное целое число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            //Верификация исходных данных
            if (a <= 0 || b <= 0)
            {
                Console.Write("Неверные исходные данные");
            }
            else
            {
                //Число в степени - a*a*a*...
                for (int i = 1; i <= b; i++)
                {
                    result *= a;
                }
                Console.Write($"{a} в степени {b} равно {result}");
            }
            Console.ReadKey();
        }
    }
}
