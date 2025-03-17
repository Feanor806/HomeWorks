namespace Task6_2_Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод исходных данных
            Console.Write("Введите выражение: ");
            string sentence = Console.ReadLine();

            //Анализ предложения
            sentence.Replace(" ","").ToLower();
            bool isPalindrom = true;

            for(int i=0;i < sentence.Length;i++)
            {
                if (sentence[i] != sentence[sentence.Length - 1 - i])
                    isPalindrom = false;
            }
            if (isPalindrom)
                Console.WriteLine("Выражение является палиндромом");
            else
                Console.WriteLine("Выражение не является палиндромом");
            Console.ReadKey();
        }
    }
}
