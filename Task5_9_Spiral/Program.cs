using System.Runtime.Intrinsics.X86;

namespace Task5_9_Spiral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            //Структура массива
            const int n = 15;
            const int m = 15;
            int[,] array = new int[n, m];
            //Счётчик вписанного числа
            int num = 1;
            //Итераторы обхода
            int a = 0; //обход строки
            int b = 0; //обход столбца
            int s = 0; //счётчик витка
            //Флаги обхода
            bool moveRight = true;
            bool moveLeft = false;
            bool moveUp = false;
            bool moveDown = false;
            bool error = false;

            //Формирование массива по спирали. Пока есть что записывать - производится обход
            while (num <= n * m)
            {
                //Проверка перехода на новый виток
                if (a == s && b == s + 1 && moveUp)
                {
                    s++;
                    array[b, a] = num++;
                    a = b;
                    moveRight = true;
                    moveDown = false;
                    moveLeft = false;
                    moveUp = false;
                    continue;
                }
                //Проверка поворота вниз
                else if (a == m - 1 - s && b == s && !moveDown && moveRight)
                {
                    moveRight = false;
                    moveLeft = false;
                    moveUp = false;
                    moveDown = true;
                }
                //Проверка поворота влево
                else if (a == m - 1 - s && b == n - 1 - s && !moveLeft && moveDown)
                {
                    moveRight = false;
                    moveLeft = true;
                    moveUp = false;
                    moveDown = false;
                }
                //Проверка поворота вверх
                else if (a == s && b == n - 1 - s && !moveUp && moveLeft)
                {
                    moveRight = false;
                    moveLeft = false;
                    moveUp = true;
                    moveDown = false;
                }
                //Если точка не характерная
                if (moveRight)
                {
                    array[b, a] = num;
                    a++;
                }
                else if (moveDown)
                {
                    array[b, a] = num;
                    b++;
                }
                else if (moveLeft)
                {
                    array[b, a] = num;
                    a--;
                }
                else if (moveUp)
                {
                    array[b, a] = num;
                    b--;
                }
                else
                {
                    error = true;
                    break;
                }
                num++;
            }
            //Вывод сформированного массива
            if (error)
            {
                Console.WriteLine("При формировании массива возниклаошибка. Результат не получен.");
            }
            else
            {
                Console.WriteLine("Основной массив:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"{array[i, j],-6}");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
