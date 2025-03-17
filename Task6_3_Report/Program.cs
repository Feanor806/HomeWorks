namespace Task6_3_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод исходных данных
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();
            Console.Write("Введите год: ");
            string year = Console.ReadLine();
            Console.Write("Введите итоговую выручку: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите количество проданных товаров: ");
            int count = Convert.ToInt32(Console.ReadLine());

            //Вычисление среднего значения
            decimal average = sum / count;

            //Вывод отчёта
            Console.WriteLine(new string('-', 20) + "\n");
            Console.WriteLine($"Отчёт о продажах за {month} {year} года");
            Console.WriteLine("\n" + new string('-', 20) + "\n");
            Console.WriteLine("Общая сумма продаж: " + String.Format($"{sum:0,0.00}" + " р."));
            Console.WriteLine("Количество проданных товаров: " + String.Format($"{count:0,0}") + " шт.");
            Console.WriteLine("Средняя стоимость товара: " + String.Format($"{average:0,0.00}") + " р.");
            Console.WriteLine("\n" + new string('-', 20) + "\n");

            Console.ReadKey();
        }
    }
}
