namespace Task3_12_NumberToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введение целого числа
            Console.Write("Введите целое трехзначное число (от 100 до 999): ");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = "";

            //Проверка правильности введенного числа
            if (number/1000 > 0 || number / 100 == 0)
            {
                Console.WriteLine("Введенное число не является трехзначным");
            }
            else
            {
                //Анализ сотен
                switch (number / 100)
                {
                    case 1:
                        result += "Сто";
                        break;
                    case 2:
                        result += "Двести";
                        break;
                    case 3:
                        result += "Триста";
                        break;
                    case 4:
                        result += "Четыреста";
                        break;
                    case 5:
                        result += "Пятьсот";
                        break;
                    case 6:
                        result += "Шестьсот";
                        break;
                    case 7:
                        result += "Семьсот";
                        break;
                    case 8:
                        result += "Восемьсот";
                        break;
                    case 9:
                        result += "Девятьсот";
                        break;
                    default:
                        result += "";
                        break;
                }
                //Анализ десятков
                if (number % 100 > 0)
                {
                    //Специальный анализ 11-19
                    if((number % 100)/10 == 1)
                    {
                        switch (number % 100)
                        {
                            case 11:
                                result += " одиннадцать";
                                break;
                            case 12:
                                result += " двенадцать";
                                break;
                            case 13:
                                result += " тринадцать";
                                break;
                            case 14:
                                result += " четырнадцать";
                                break;
                            case 15:
                                result += " пятнадцать";
                                break;
                            case 16:
                                result += " шестнадцать";
                                break;
                            case 17:
                                result += " семнадцать";
                                break;
                            case 18:
                                result += " восемнадцать";
                                break;
                            case 19:
                                result += " девятнадцать";
                                break;
                            default:
                                result += "";
                                break;
                        }
                    }
                    //Остальные случаи
                    else
                    {
                        switch (number % 100 / 10)
                        {
                            case 2:
                                result += " двадцать";
                                break;
                            case 3:
                                result += " тридцать";
                                break;
                            case 4:
                                result += " сорок";
                                break;
                            case 5:
                                result += " пятьдесят";
                                break;
                            case 6:
                                result += " шестьдесят";
                                break;
                            case 7:
                                result += " семдесят";
                                break;
                            case 8:
                                result += " восемдесят";
                                break;
                            case 9:
                                result += " девяносто";
                                break;
                            default:
                                result += "";
                                break;
                        }
                        //Анализ единиц
                        if(number % 10 > 0)
                        {
                            switch (number % 10)
                            {
                                case 1:
                                    result += " один";
                                    break;
                                case 2:
                                    result += " два";
                                    break;
                                case 3:
                                    result += " три";
                                    break;
                                case 4:
                                    result += " четыре";
                                    break;
                                case 5:
                                    result += " пять";
                                    break;
                                case 6:
                                    result += " шесть";
                                    break;
                                case 7:
                                    result += " семь";
                                    break;
                                case 8:
                                    result += " восемь";
                                    break;
                                case 9:
                                    result += " девять";
                                    break;
                                default:
                                    result += "";
                                    break;
                            }
                        } 
                    }
                }
                Console.WriteLine($"Введенное число: {result}");
                Console.ReadKey();
            }
        }
    }
}
