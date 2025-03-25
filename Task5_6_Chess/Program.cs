namespace Task5_6_Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            const int arrayCount = 5;
            int[,] array = new int[arrayCount, arrayCount];

            //Формирование массива
            Console.WriteLine("Основной массив:");
            for (int i = 0; i < arrayCount; i++)
            {
                for (int j = 0; j < arrayCount; j++)
                {
                    array[i, j] = (i % 2 == 0 && j % 2 == 0) ? 1 :
                        (i % 2 > 0 && j % 2 > 0) ? 1 : 0;
                    Console.Write($"{array[i, j],2}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
