namespace Tast6_1_Sentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод исходных данных
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();

            //Анализ предложения
            string[] words = sentence.Split(' ');
            int maxLength = 0;
            string? longest = null;

            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    longest = word;
                    maxLength = word.Length;
                }
            }
            Console.Write("Самое длинное слово: {0}", longest);
            Console.ReadKey();
        }
    }
}
