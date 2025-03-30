namespace Task8_2_ValidateAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.Write("Введите возраст: ");
            try 
            {
                age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
                Console.WriteLine("Возраст корректный");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введен некорректный возраст");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.ReadKey();
        }
        static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Возраст не может быть отрицательным");
            }
            if (age > 150)
            {
                throw new ArgumentOutOfRangeException("Возраст слишком большой");
            }
        }
    }
}
