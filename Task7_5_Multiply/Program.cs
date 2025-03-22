namespace Task7_5_Multiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = Multiply(5,12);
            Console.WriteLine(result1);
            double result2 = Multiply(5.5, 12.5); ;
            Console.WriteLine(result2);
            Console.ReadKey();
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
