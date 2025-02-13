namespace Task1_1
{
    internal class Program
    {
        /// <summary>
        /// Основной метод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число Б:");
            byte b = Convert.ToByte(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"Сумма {a} + {b} = {sum}");
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}
