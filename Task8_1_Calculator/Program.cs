namespace Task8_1_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вычисления будут продолжаться, пока пользователь их не остановит
            bool cycle = true;
            do
            {
                bool error = false;
                char op = ' ';
                int first = 0;
                int second = 0;
                double result;
                Console.WriteLine(new string('-', 20));
                try
                {
                    //Ввод исходных данных пользователем
                    Console.Write("Введите первое число: ");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    second = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите оператор (+,-,*,/): ");
                    op = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    ValidateOperator(op);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Некорректный ввод - {ex.Message}");
                    error = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Выбран некорректный оператор - {ex.Message}");
                    error = true;
                }
                //Если найдены проблемы - вычисление не производится
                if (!error)
                {
                    try
                    {
                        result = Calculate(op,first,second);
                        Console.WriteLine($"Результат: {result}");
                    }
                    catch(DivideByZeroException ex)
                    {
                        Console.WriteLine($"Деление на 0 не допускается - {ex.Message}");
                    }
                }
                //Подтверждение от пользователя о продолжении вычислений
                Console.WriteLine($"Продолжить вычисление (Y для продолжения)");
                string answer = Convert.ToString(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (!answer.ToUpper().Equals("Y") || answer == null)
                    cycle = false;
            }
            while (cycle);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Работа завершена");
            Console.ReadKey();
        }

        static void ValidateOperator(char op)
        {
            if(!(new char[] { '*', '/', '+', '-' }.Contains(op)))
            {
                throw new ArgumentException($"Символ {op} не является арифметическим оператором");
            }
        }

        static double Calculate(char op, int first, int second)
        {
            switch (op)
            {
                case '+':
                    return (double)first + (double)second;
                case '-':
                    return (double)first - (double)second;
                case '*':
                    return (double)first * (double)second;
                case '/':
                    return (double)first / (double)second;
                default:
                    return 0.0;
            }
        }
    }
}
