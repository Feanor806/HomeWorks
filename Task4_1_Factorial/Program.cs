namespace Task4_1_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Получение исходных данных
            Console.Write("Введите натуральное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 0;

            //Проверка на натуральное число и ноль
            if(number < 0)
            {
                Console.WriteLine("Отрицательные числа не являются натуральными");
            }
            //Случай 0!
            else if(number == 0)
            {
                Console.WriteLine("0! всегда равен 1");
            }
            //Проверка переполнения
            else if (number >= 13)
            {
                Console.WriteLine($"{number}! слишком большое число для хранеия в int");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial = (i == 1) ? 1 : (factorial * i);
                }
                Console.WriteLine($"{number}! равен {factorial}.");
            }
            Console.ReadKey();
        }
    }
}
