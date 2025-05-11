using System.Text;

namespace Task13_2_DaVinciCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encrypt("HELLO 123"));
        }

        //Алфавит латинский строчный
        static string alphabetLatinLower = "abcdefghijklmnopqrstuvwxyz";
        //Алфавит латинский заглавный
        static string alphabetLatinHigh = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //Алфавит кириллический строчный
        static string alphabetCyrilLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        //Алфавит кириллический заглавный
        static string alphabetCyrilHigh = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        static string Encrypt (string text)
        {
            StringBuilder sb = new StringBuilder ();
            for (int i = 0; i < text.Length; i++) 
            {
                if (alphabetLatinLower.Contains(text[i]))
                {
                    sb.Append(alphabetLatinLower[
                        alphabetLatinLower.Length -
                        alphabetLatinLower.IndexOf(text[i])
                        - 1]);
                }
                else if (alphabetLatinHigh.Contains(text[i]))
                {
                    sb.Append(alphabetLatinHigh[
                        alphabetLatinHigh.Length -
                        alphabetLatinHigh.IndexOf(text[i])
                        - 1]);
                }
                else if (alphabetCyrilLower.Contains(text[i]))
                {
                    sb.Append(alphabetCyrilLower[
                        alphabetCyrilLower.Length -
                        alphabetCyrilLower.IndexOf(text[i])
                        - 1]);
                }
                else if (alphabetCyrilHigh.Contains(text[i]))
                {
                    sb.Append(alphabetCyrilHigh[
                        alphabetCyrilHigh.Length -
                        alphabetCyrilHigh.IndexOf(text[i])
                        - 1]);
                }
                else
                {
                    sb.Append(text[i]);
                }
            }
            return sb.ToString();
        }
    }
}
