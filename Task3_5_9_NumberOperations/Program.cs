namespace Task3_5_10_NumberOperations
{
    internal class Program
    {
        private const string V = "ДА";

        static void Main(string[] args)
        {
            //Введение числа
            Console.Write("Введите число для анализа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string answer;

            //Окончание на 0
            Console.WriteLine("Число заканчивается на 0?");
            answer = (a % 10 == 0)? "ДА":"НЕТ";
            Console.WriteLine(answer);

            //Проверка четности
            Console.WriteLine("Число является четным?");
            answer = (a % 2 == 0) ? "ДА" : "НЕТ";
            Console.WriteLine(answer);
           
            //Проверка двухзначности
            Console.WriteLine("Число является двухзначным?");
            answer = (a / 10 > 0 && a / 10 < 10) ? "ДА" : "НЕТ";
            Console.WriteLine(answer);

            //Проверка попадания в диапазон
            Console.WriteLine("Число попадает в диапазон от -10 до 10 (включительно)?");
            answer = (a >= -10 && a <= 10) ? "ДА" : "НЕТ";
            Console.WriteLine(answer);

            //Проверка нахождения вне диапазона
            Console.WriteLine("Число не попадает в диапазон от -10 до 10 (включительно)?");
            answer = (a <= -10 && a >= 10) ? "ДА" : "НЕТ";
            Console.WriteLine(answer);

            Console.ReadKey();
        }
    }
}
