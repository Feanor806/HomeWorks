using System;

namespace Block14_1_Transforms
{
    internal class Program
    {
        delegate int Transformer(int arg1);

        static int[] Transform(int[] array, Transformer transformer)
        {
            int[] result = new int[array.Length];
            for (int i=0; i < array.Length;i++)
            {
                result[i] = transformer(array[i]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] array = { -2, -1, 4, 5 };

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Удвоение:");
            int[] arrayMulti = Transform(array, x => x * 2);
            foreach (int item in arrayMulti) 
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Квадрат:");
            arrayMulti = Transform(array, x => x * x);
            foreach (int item in arrayMulti)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Модуль:");
            arrayMulti = Transform(array, x => Math.Abs(x));
            foreach (int item in arrayMulti)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
