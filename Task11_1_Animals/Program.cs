namespace Task11_1_Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            [
                new Dog(),
                new Cat()
            ];

            foreach (var animal in animals)
            {
                animal.GetInfo();
            }
            Console.ReadKey();
        }

        public abstract class Animal
        {
            public abstract string Name { get;}
            public abstract void Say();
            public void GetInfo()
            {
                Console.WriteLine($"{Name}");
                Say();
            }
        }

        public class Dog : Animal
        {
            public override string Name => "Собака";
            public override void Say()
            {
                Console.WriteLine($"Гав!");
            }
        }

        public class Cat : Animal
        {
            public override string Name => "Кошка";
            public override void Say()
            {
                Console.WriteLine($"Мяу!");
            }
        }
    }
}
