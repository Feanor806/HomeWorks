namespace Task5_3_MinMaxIndexes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            const int arrayCount = 10;
            int[] array = new int[arrayCount];
            int maxNumber = 0;
            int minNumber = 0;
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < arrayCount; i++)
            {
                Random rnd = new();
                array[i] = rnd.Next(0, 51);
                Console.Write($"{array[i],-3}");
            }
            Console.WriteLine();
            for (int i = 0; i < arrayCount; i++)
            {
                if (i == 0)
                {
                    maxNumber = minNumber = array[i];
                    maxIndex = minIndex = i;
                }
                else if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                    maxIndex = i;
                }
                else if (array[i] < minNumber)
                {
                    minNumber = array[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"Максимальное значение {maxNumber} с индексом {maxIndex}. Минимальное значение {minNumber}, с индексом {minIndex}");
            Console.ReadKey();
        }
    }
}
