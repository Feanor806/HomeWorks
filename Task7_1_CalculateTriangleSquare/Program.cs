namespace Task7_1_CalculateTriangleSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод исходных данных
            Console.WriteLine("Введите данные для первого треугольника:");
            int[] first = SetTriangle();
            Console.WriteLine("Введите данные для второго треугольника:");
            int[] second = SetTriangle();

            //Определение площадей
            double firstSquare = CalcTriangleSquare(first);
            double secondSquare = CalcTriangleSquare(second);

            //Вывод результата
            if (firstSquare > secondSquare)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if (firstSquare < secondSquare)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }
        }
        /// <summary>
        /// Метод для задачи сторон треугольника
        /// </summary>
        /// <returns></returns>
        static int[] SetTriangle()
        {
            int[] triangle = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Введите {i + 1} сторону треугольника: ");
                triangle[i] = Convert.ToInt32(Console.ReadLine());
            }
            return triangle;
        }
        /// <summary>
        /// Метод для определения площади треугольника по формуле Герона
        /// </summary>
        /// <param name="triangle">Массив из длин сторон треугольника</param>
        /// <returns></returns>
        static double CalcTriangleSquare(int[] triangle)
        {
            double halfPerimeter = Convert.ToDouble((triangle[0] + triangle[1] + triangle[2]) / 2);
            double triangleSquare = Math.Sqrt(halfPerimeter * 
                (halfPerimeter - Convert.ToDouble(triangle[0])) * 
                (halfPerimeter - Convert.ToDouble(triangle[1])) * 
                (halfPerimeter - Convert.ToDouble(triangle[2])));
            return triangleSquare;
        }
    }
}
