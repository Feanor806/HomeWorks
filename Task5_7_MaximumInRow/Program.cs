namespace Task5_7_MaximumInRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            const int rowCount = 10;
            const int collumnCount = 5;
            int[,] array = new int[rowCount, collumnCount];

            //Формирование массива
            Console.WriteLine("Основной массив:");
            for (int i = 0; i < rowCount; i++)
            {
                int rowMax = 0;
                for (int j = 0; j < collumnCount; j++)
                {
                    Random rnd = new();
                    array[i, j] = rnd.Next(0, 11);
                    rowMax = j == 0 ? array[i, j] :
                        array[i, j] > rowMax ? array[i, j] : rowMax;
                    Console.Write($"{array[i, j],-3}");
                }
                Console.Write($"\t|max :{rowMax}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
