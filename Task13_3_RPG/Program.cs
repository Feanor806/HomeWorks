namespace Task13_3_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Флаг продолжения
            bool wantMore = false;
            //Флаг хода
            bool playerTurn = true;

            Console.WriteLine("=== Игра \'Битва с монстром\' ===");

            //Создание персонажа
            Console.Write("Введите имя героя: ");
            string heroName = Console.ReadLine().ToString();
            int heroHealth = 0;
            while (heroHealth == 0)
            {
                Console.Write("Введите начальное здоровье героя: ");
                try
                {
                    heroHealth = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Некорректный формат возраста героя");
                }
            }
            Player player1 = new(heroName, heroHealth);

            do
            {
                //Счётчик ходов
                int turnCount = 1;
                Monster goblin = new();
                do
                {
                    Console.WriteLine(new string('-', 20));
                    Console.WriteLine($"Ход {turnCount}. {player1.Name} - {player1.Health} HP. {goblin.Name} - {goblin.Health} HP.");
                    if (playerTurn)
                    {
                        Console.WriteLine("Ходит игрок. Выберете действие:");
                        string healInfo = player1.HealthPotion > 0 ? $"2 - Выпить зелье лечения ({player1.HealthPotion})" : "Лечение недоступно";
                        Console.Write($"1 - Атаковать. {healInfo}: ");
                        string option = Console.ReadKey().KeyChar.ToString();
                        Console.WriteLine();

                        if (Convert.ToInt32(option) == 1)
                        {
                            player1.Attack(goblin);
                        }
                        else if (player1.HealthPotion > 0 && Convert.ToInt32(option) == 2)
                        {
                            player1.UseHealthPotion();
                        }
                        else
                        {
                            Console.WriteLine("Вы замешкались и пропускаете ход.");
                        }
                        playerTurn = false;
                    }
                    else
                    {
                        Console.WriteLine("Ходит противник.");
                        Random rnd = new Random();
                        goblin.Damage = rnd.Next(1, 7);
                        goblin.Attack(player1);
                        playerTurn = true;
                    }
                    turnCount++;
                }
                while (player1.IsAlive && goblin.IsAlive);
                Console.WriteLine(new string('+', 20));
                if (player1.IsAlive)
                {
                    Console.WriteLine($"Победа! У вас осталось {player1.Health} HP.");
                }
                else
                {
                    Console.WriteLine($"Вы проиграли! {goblin.Name} насмехается над вами!");
                }
                Console.WriteLine(new string('+',20));
                Console.Write("Хотите сыграть еще раз? Нажмите Y если да:");
                Console.WriteLine();
                if (Console.ReadKey().KeyChar.ToString() == "y")
                {
                    wantMore = true;
                    player1.Health = heroHealth;
                    player1.HealthPotion = 3;
                    Console.WriteLine();
                    Console.WriteLine("Герой подлечился и восполнил запасы.");
                    Console.WriteLine(new string('+', 20));
                }
                else
                {
                    wantMore = false;
                }
            }
            while (wantMore);
            Console.ReadKey();
        }

        public class Character
        {
            public virtual string? Name { get; }
            public int Health { get; set; }
            public int Damage { get; set; }
            public bool IsAlive => Health > 0;
            public Character(int health, int damage)
            {
                Health = health;
                Damage = damage;
            }
            public virtual void Attack(Character target)
            {
                Console.WriteLine($"{target.Name} получает {Damage} урона.");
                target.Health -= Damage;
            }
        }
        public class Player : Character
        {
            public int HealthPotion { get; set; } = 3;
            public void UseHealthPotion()
            {
                HealthPotion--;
                Health += 10;
                Console.WriteLine($"Вы использовали зелье лечения. Здоровье - {Health} HP.");
            }
            public override string? Name { get; }

            public Player(string name, int health) : base(health, 5)
            {
                Name = name;
                Health = health;
            }

        }

        public class Monster : Character
        {
            public override string? Name => "Злобный гоблин";

            public Monster() : base(20, 0)
            {

            }
        }
    }
}
