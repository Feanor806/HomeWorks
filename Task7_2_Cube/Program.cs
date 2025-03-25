namespace Task7_2_Cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Ввод исходных данных данных
            Console.Write("Введите длину ребра куба: ");
            double edge = Convert.ToDouble(Console.ReadLine());

            double volume;
            double surface;

            //Расчёт параметров
            CalcCube(edge, out volume, out surface);

            //Вывод результата
            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь поверхности куба: {surface}");

            Console.ReadKey();
        }
        /// <summary>
        /// Метод для расчёта параметров куба
        /// </summary>
        /// <param name="edgeLength">Длина стороны</param>
        /// <param name="volume">Объем куба</param>
        /// <param name="surfaceArea">Площадь поверхности куба</param>
        static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            volume = Math.Pow(edgeLength, 3);
            surfaceArea = 6 * Math.Pow(edgeLength, 2);
        }
    }
}
