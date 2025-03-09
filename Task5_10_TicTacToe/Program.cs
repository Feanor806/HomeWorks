namespace Task5_10_TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            const int arrayCount = 5;
            int[,] array = new int[arrayCount, arrayCount];
            bool ticWin = false;
            //Формирование массива. При создании проверяется выигрыш по строке
            for (int i = 0; i < arrayCount; i++)
            {
                bool rowWin = true;
                for (int j = 0; j < arrayCount; j++)
                {
                    Random rnd = new();
                    array[i, j] = rnd.Next(0, 2);
                    if (array[i, j]==0)
                    {
                        rowWin = false;
                    }
                    Console.Write($"{array[i, j],-3}");
                }
                if (rowWin)
                {
                    ticWin = true;
                }
                Console.WriteLine();
            }
            //Проверка основных диагонелей, если не был найден выигрыш по строке
            if (!ticWin)
            {
                bool mainDiagonal = true;
                bool secondDiagonal = true;
                for (int i = 0; i < arrayCount; i++)
                {
                    for (int j = 0; j < arrayCount; j++)
                    {
                        if (i == j && array[i, j] == 0)
                        {
                            mainDiagonal = false;
                        }
                        if (j == arrayCount - 1 - i && array[i, j] == 0)
                        {
                            secondDiagonal = false;
                        }
                    }
                }
                if (mainDiagonal||secondDiagonal)
                {
                    ticWin = true;
                }
            }
            //Проверка столбцов, если выигрыш не был определен по строкам и диагоналям
            if (!ticWin)
            {
                for (int i = 0; i < arrayCount; i++)
                {
                    bool collumnWin = true;
                    for (int j = 0; j < arrayCount; j++)
                    {
                        if (array[j, i] == 0)
                        {
                            collumnWin = false;
                            break;
                        }
                    }
                    if (collumnWin)
                    {
                        ticWin = true;
                        break;
                    }
                }
            }
            //Вывод результата
            if (ticWin)
            {
                Console.WriteLine("Единицы выиграли");
            }
            else
            {
                Console.WriteLine("Единицы не выиграли");
            }
            Console.ReadKey();
        }
    }
}
