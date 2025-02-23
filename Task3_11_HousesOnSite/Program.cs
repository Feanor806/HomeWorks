namespace Task3_11_HousesOnSite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод размеров участка
            Console.WriteLine("Введите размеры участка: ");
            Console.Write("Размер А: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Размер B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //Ввод размеров дома 1
            Console.WriteLine("Введите размеры первого дома: ");
            Console.Write("Размер P: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Размер Q: ");
            double q = Convert.ToDouble(Console.ReadLine());

            //Ввод размеров дома 2
            Console.WriteLine("Введите размеры второго дома: ");
            Console.Write("Размер R: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Размер S: ");
            double s = Convert.ToDouble(Console.ReadLine());

            bool possible = false;

            //Оба дома на площадке в шахматном порядке с разной комбинацией сторон
            if ((p + r <= a && q + s <= b)||(p + r <= b && q + s <= a)||(p + s <= a && q + r <= b) || (p + s <= b && q + r <= a))
            {
                possible = true;
            }
            //Размер участка A x B
            else if (p + r <= a && Math.Max(q, s) <= b)
            {
                possible = true;
            }
            else if (p + s <= a && Math.Max(q, r) <= b)
            {
                possible = true;
            }
            else if (q + r <= a && Math.Max(p, s) <= b)
            {
                possible = true;
            }
            else if (q + s <= a && Math.Max(p, r) <= b)
            {
                possible = true;
            }
            //Размер участка B x A
            else if (p + r <= b && Math.Max(q, s) <= a)
            {
                possible = true;
            }
            else if (p + s <= b && Math.Max(q, r) <= a)
            {
                possible = true;
            }
            else if (q + r <= b && Math.Max(p, s) <= a)
            {
                possible = true;
            }
            else if (q + s <= b && Math.Max(p, r) <= a)
            {
                possible = true;
            }

            //Вывод результата
            if (possible)
            {
                Console.WriteLine("Дома могут быть размещены на участке");
            }
            else
            {
                Console.WriteLine("Дома нельзя разместить на участке");
            }
            Console.ReadKey();
        }
    }
}
