using System.Text.RegularExpressions;

namespace Task6_5_PhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод исходных данных
            Console.Write("Введите номер телефона в формате +#(###)###-##-##: ");
            string phone = Console.ReadLine();

            Regex regex = new Regex(@"^\+[0-9]{1,2}\([0-9]{3}\)[0-9]{3}\-[0-9]{2}\-[0-9]{2}$");

            if (regex.IsMatch(phone))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("не ok");
            }
            Console.ReadKey();
        }
    }
}
