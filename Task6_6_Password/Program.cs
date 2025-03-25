using System.Text.RegularExpressions;

namespace Task6_6_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Флаг ввода корректного пароля
            bool correctPassword = false;

            do
            {
                Console.WriteLine(new string('-',20));
                Console.Write("Введите пароль: ");
                string? password = Console.ReadLine();

                Regex passOptions = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!#;%:?*])[a-zA-Z0-9!#;%:?*]{14,}$");
                if (passOptions.IsMatch(password))
                    correctPassword = true;
                else
                {
                    Console.WriteLine("Введен некорректный пароль.\nПароль должен состоять не менее чем из 14 символов.\nПароль должен содержать:\n-Хотя бы одну строчную латинскую букву.\n-Хотя бы одну заглавную латинскую букву.\n-Хотя бы одну цифру.\n-Хотя бы один символ из набора: !#;%:?*.");
                    Console.WriteLine(new string('-', 20));
                }
            }
            while (!correctPassword);
        }
    }
}
