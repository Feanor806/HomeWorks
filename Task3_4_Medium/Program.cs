namespace Task3_4_Medium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введение трех чисел
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            //Сравнение числел и вывод результата

            if (a==b && a==c)
            {
                Console.WriteLine($"Все числа равны, среднее значение: {a}");
            }
            else if ((a>=b && a<=c) || (a >= c && a <= b))
            {
                Console.WriteLine($"Среднее значение имеет число A: {a}");
            }
            else if ((b >= a && b <= c) || (b >= c && b <= a))
            {
                Console.WriteLine($"Среднее значение имеет число B: {b}");
            }
            else
            {
                Console.WriteLine($"Среднее значение имеет число С: {c}");
            }
            Console.ReadKey();
        }
    }
}
