namespace Task14_1_Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание списка команды
            List<string> team = new();
            //Добавление участников методом Add
            team.Add("Иванов");
            team.Add("Петров");
            team.Add("Сидоров");

            //Добавление участника методом Insert на позицию с индексом 1
            team.Insert(1, "Козлов");

            //Проверка наличия игрока: Петров
            Console.WriteLine($"Есть ли игрок 'Петров' в команде? {team.Contains("Петров")}");

            //Удаление игрока: Сидоров
            Console.WriteLine($"Игрок 'Сидоров' исключен? {team.Remove("Сидоров")}");

            //Поиск индекса игрока: Козлов
            Console.WriteLine($"Игрок 'Козлов' имеет индекс: {team.IndexOf("Козлов")}");

            //Сортировка списка
            team.Sort();

            //Вывод списка игроков
            for (int i = 0; i < team.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {team[i]}");
            }

            //Проверка наполненности списка команды
            Console.WriteLine($"В команде есть игроки? {team.Count > 0}");

            //Очистка списка
            team.Clear();
            Console.WriteLine($"Количество игроков в команде после очистки: {team.Count}");

            Console.ReadKey();

        }
    }
}
