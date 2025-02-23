namespace Task3_1_ComparisonTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводим числа для сравнения
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            //Сравниваем числа, выводим результат
            if (a > b)
            {
                Console.WriteLine($"{a} > {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"{a} < {b}");
            }
            else 
            {
                Console.WriteLine($"{a} = {b}");
            }
            Console.ReadKey();
        }
    }
}
