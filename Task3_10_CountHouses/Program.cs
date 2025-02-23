namespace Task3_10_CountHouses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введение числа
            Console.Write("Введите число построенных домов: ");
            int count = Convert.ToInt32(Console.ReadLine());

            if (count % 10 == 1 && count % 100 != 11)
            {
                Console.WriteLine($"Был построен {count} дом.");
            }
            else if ((count % 10 == 2 && count % 100 != 12) || (count % 10 == 3 && count % 100 != 13) || (count % 10 == 4 && count % 100 != 14))
            {
                Console.WriteLine($"Было построено {count} дома.");
            }
            else 
            {
                Console.WriteLine($"Было построено {count} домов.");
            }
            Console.ReadKey();
        }
    }
}
