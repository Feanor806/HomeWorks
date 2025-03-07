namespace Task4_5_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Переменная для присваивания значения
            int a = 0;

            //Изначально число вне диапазона, цикл с постусловием
            do
            {
                Console.Write("Введите число от 20 до 60: ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 20 || a > 60);

            Console.WriteLine($"Введено число: {a}");
            Console.ReadKey();
        }
    }
}
