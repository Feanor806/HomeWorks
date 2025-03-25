namespace Task7_4_FindMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}");
        }

        static int FindMax(params int[] numbers)
        {
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((i > 0 && numbers[i] > max) || i == 0)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}
