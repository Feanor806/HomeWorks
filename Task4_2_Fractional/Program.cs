namespace Task4_2_Fractional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Получение исходных данных
            Console.Write("Введите натуральное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int fraction = 0;
            int denominator = 0;
            int whole = 0;

            double decimalResult = 0.0;

            //Проверка на натуральное число
            if (number < 0)
            {
                Console.WriteLine("Число не является натуральным");
            }
            //Проверка деления на 0
            else if (number == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            //Простой путь - прямое получение double. Но условие задано в виде дробей. Ищем общий знаменатель.
            else
            {
                for (int i = 2; i <= number; i++)
                {
                    fraction = (i == 2) ? 1 : fraction * i + denominator;
                    denominator = (i == 2) ? 2 : denominator *= i;

                    //Дублирующие переменные для поиска наибольшего общего делителя
                    int nod = denominator;
                    int fract = fraction;

                    //Проверяется общий делитель для сокращения дроби
                    while (nod != 0 && fract != 0)
                    {
                        //Если числитель делится на знаменатель без остатка - делитель найден
                        if (fract % nod > 0)
                        {
                            //Временная переменная для сохранения значения числителя
                            int temp = fract;
                            //Числитель приравнивается к знаменателю
                            fract = nod;
                            //В качестве возможного общего делителя принимается остаток от деления
                            nod = temp % fract;
                        }
                        else break;
                    }
                    //При необходимости сокращаем дробь
                    if (nod > 1)
                    {
                        fraction /= nod;
                        denominator /= nod;
                    }
                }

                //Получение целой части
                whole = fraction / denominator;
                fraction -= (whole * denominator);
                whole += 1;

                //Результат в десятичных долях
                decimalResult = Convert.ToDouble(whole + Convert.ToDouble(fraction) / denominator);
                Console.WriteLine($"Итоговая дробь: {whole} целых {fraction}/{denominator}, что соотвтетсвует десятичной дроби {decimalResult}");
            }
            Console.ReadKey();
        }
    }
}
