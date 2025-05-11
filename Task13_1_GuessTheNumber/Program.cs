using System.Runtime;

namespace Task13_1_GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            //Загаданное число
            int number = rnd.Next(1, 101);

            //Флаг угадывания
            bool guess = false;

            //Число попыток
            int tries = 3;

            Console.WriteLine("Угадай число от 1 до 100!");
            do
            {
                Console.WriteLine(new string('=',20));
                //Debug
                //Console.WriteLine($"Загадано число: {number}");
                Console.WriteLine($"Осталось {tries} попыток");
                Console.Write("Введи число: ");
                int attempt;
                try
                {
                    attempt = Convert.ToInt32(Console.ReadLine());
                    if (attempt<1|| attempt>100)
                    {
                        Console.WriteLine("Неправильное число, попытка утрачена.");
                    }
                    else if(attempt == number)
                    {
                        guess = true;
                    }
                    else if (attempt < number)
                    {
                        Console.WriteLine($"{HowClose(number, attempt)} Искомое число больше.");
                    }
                    else if (attempt > number)
                    {
                        Console.WriteLine($"{HowClose(number, attempt)} Искомое число меньше.");
                    }
                    else
                    {
                        Console.WriteLine("Что-то пошло не так, попытка утрачена.");
                    }
                }
                catch
                {
                    Console.WriteLine("Неверный формат числа, попытка утрачена.");
                }
                tries--;
            }
            while (!guess && tries > 0);

            Console.WriteLine(new string('=', 20));

            if (guess) 
            {
                Console.WriteLine($"Победа! Загаданное число: {number}");
            }
            else if (tries == 0)
            {
                Console.WriteLine($"Поражение! Попытки закончились. Загаданное число: {number}");
            }
            else
            {
                Console.WriteLine($"Что-то пошло не так.");
            }
        }

        static string HowClose(int target,int attempt)
        {
            if((attempt >= target - 3) && (attempt <= target + 3))
            {
                return "Горячо!";
            }
            else if((attempt >= target - 15) && (attempt <= target + 15))
            {
                return "Тепло.";
            }
            else
            {
                return "Холодно.";
            }
        }
    }
}
