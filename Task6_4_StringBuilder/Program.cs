using System.Text;

namespace Task6_4_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Подготовка строки отчёта
            StringBuilder result = new StringBuilder();
            result.Append("Имя: [имя], Возраст: [возраст], Город: [город]");

            //Сбор данных пользователя
            Console.Write("Введите имя: ");
            result.Replace("[имя]", Console.ReadLine());
            Console.Write("Введите возраст: ");
            result.Replace("[возраст]", Console.ReadLine());
            Console.Write("Введите город: ");
            result.Replace("[город]", Console.ReadLine());

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
