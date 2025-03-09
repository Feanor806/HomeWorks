namespace Task5_5_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            const int arrayCount = 10;
            int[] array = new int[arrayCount];

            //Формирование массива
            Console.WriteLine("Основной массив:");
            for (int i = 0; i < arrayCount; i++)
            {
                Random rnd = new();
                array[i] = rnd.Next(-50, 51);
                Console.Write($"{array[i],-4}");
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < arrayCount-1; i++)
            {
                //Сортировка первой половины
                if (i < arrayCount / 2)
                {
                    for(int j = i+1; j < arrayCount/2; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        } 
                    }
                }
                //Исключение середины из участия в сортировке для массива из нечетного числа элементов
                else if (arrayCount % 2 > 0 && i == arrayCount / 2)
                {
                    continue;
                }
                //Сортировка второй части массива
                else
                {
                    for (int j = i + 1; j < arrayCount; j++)
                    {
                        if (array[i] < array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            for(int i = 0;i< arrayCount; i++)
            {
                Console.Write($"{array[i],-4}");
            }
            Console.ReadKey();
        }
    }
}
