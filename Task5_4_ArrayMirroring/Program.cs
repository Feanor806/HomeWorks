namespace Task5_4_ArrayMirroring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            const int arrayCount = 10;
            int[] array = new int[arrayCount];
            Console.WriteLine("Основной массив:");
            for (int i = 0; i < arrayCount; i++)
            {
                Random rnd = new();
                array[i] = rnd.Next(0, 11);
                Console.Write($"{array[i],-3}");
            }
            Console.WriteLine();
            Console.WriteLine("Отзеркаленный массив:");
            for (int i = 0; i < arrayCount; i++)
            {
                if(i< arrayCount / 2)
                {
                    int temp = array[arrayCount - 1 - i];
                    array[arrayCount - 1 - i] = array[i];
                    array[i] = temp;
                    Console.Write($"{array[i],-3}");
                }
                else
                {
                    Console.Write($"{array[i],-3}");
                }
            }
            Console.ReadKey();
        }
    }
}
