namespace Task4_6_PowerOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введение исходных данных
            Console.Write("Введите положительное целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //Вспомогательные переменные
            int i = 0;
            int counter = number;

            //Верификация введенного числа
            if (number <= 0)
            {
                Console.WriteLine("Некорректные исходные данные");
            }
            else
            {
                //Пока число делится на 2 без остатка - оно потенциально является степенью
                while (counter % 2 == 0)
                {
                    counter /= 2;
                    i++;
                }
                if (number == Math.Pow(2, i))
                {
                    Console.WriteLine($"Число {number} является 2 в степени {i}");
                }
                else
                {
                    Console.WriteLine($"Число не является степенью 2");
                }
            }
            Console.ReadKey();
        }
    }
}
