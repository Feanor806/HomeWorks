namespace Task16_1_Async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('#',20));
            Console.WriteLine("Блок задач продолжения");

            Console.WriteLine("Старт процесса генерации массива задачей продолжения");
            Task<int[]> task1 = Task.Run(() => GenerateArray(10) );
            Console.WriteLine("Старт процесса вычисления среднего арифметического задачей продолжения");
            Task<double> task2 = task1.ContinueWith(t => 
            {
                int[] array = t.Result;
                return GetAverage(array);
            });

            Console.WriteLine(task2.Result);

            Console.WriteLine(new string('#', 20));
            Console.WriteLine("Блок async/await");
            Console.WriteLine("Старт процесса асинхронной генерации массива");
            int[] arrayAsync = GenerateArrayAsync(10).Result;
            Console.WriteLine("Старт процесса асинхронного вычисления среднего арифметического");
            double averageAsync = GetAverageAsync(arrayAsync).Result;
            Console.WriteLine(averageAsync);
        }

        static int[] GenerateArray(int size)
        {
            Console.WriteLine("Генерация массива...");
            var random = new Random();
            int[] array = new int[size];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1,10);
                Console.Write($"{array[i]} ");
                Thread.Sleep(400);
            }

            Console.WriteLine("\nМассив сгенерирован");
            return array;
        }

        static double GetAverage(int[] array)
        {
            Console.WriteLine("Вычисление среднего арифметического...");
            double average = (double)array.Sum()/array.Length;
            Thread.Sleep(500);
            return average;
        }

        static async Task<int[]> GenerateArrayAsync(int size)
        {
            int[] array = await Task.Run(() => GenerateArray(size));
            return array;
        }

        static async Task<double> GetAverageAsync(int[] array)
        {
            double average = await Task.Run(() => GetAverage(array));
            return average;
        }
    }
}
