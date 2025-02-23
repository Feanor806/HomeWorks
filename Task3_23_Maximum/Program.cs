namespace Task3_23_Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Решение 1 - основное, по теме урока - использование нескольких условий if
            //Масштабирование - ввод дополнительной переменной, редактирование условий
            //Вводим исходные числа
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            //Выполнение сравнения и вывод результата
            if (a == b && a == c)
            {
                Console.WriteLine($"Все числа равны");
            }
            if(a > b && a > c)
            {
                Console.WriteLine($"Число A наибольшее: {a}");
            }
            else if(b >= c)
            {
                Console.WriteLine($"Число B наибольшее: {b}");
            }
            else
            {
                Console.WriteLine($"Число C наибольшее: {c}");
            }
            Console.ReadKey();
            //Конец решения 1

            //============================================================================================

            /*//Решение 2 - используется цикл for для получения значений переменных, 
             * используется сортировка массива для поиска наибольшего значения
             * максимальное масштабирование
            //Вводим исходные числа
            List<int> lstInts = new List<int>();
            Console.Write("Введите количество чисел, которые хотите сравнить: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++) 
            {
                Console.Write($"Введите следующее число ({i+1}/{count}): ");
                lstInts.Add(Convert.ToInt32(Console.ReadLine()));
            }
            //Сортируем список
            lstInts.Sort();
            //Определяем наибольшее число
            Console.WriteLine($"Наибольшее число: {lstInts[count-1]}");
            //Конец решения 2*/

            //============================================================================================

            /*//Решение 3 - аналогично решению 1, использование тернарного оператора
            //Масштабирование - ввод дополнительной переменной, дополнение тернарного опреатора
            //Вводим исходные числа
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            //Максимальное значение м вывод результата:

            if(a == b && a == c)
            {
                Console.WriteLine($"Все числа равны");
            }
            else
            {
                int max =
                (a > b && a > c) ? a :
                ((b >= c) ? b : c);
                Console.WriteLine($"Наибольшее число: {max}");
            }
            
            Console.ReadKey();
            //Конец решения 3*/
        }
    }
}
