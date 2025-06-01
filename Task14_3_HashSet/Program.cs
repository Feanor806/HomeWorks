namespace Task14_3_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание набора уникальных адресов
            HashSet<string> emails = new();

            //Добавление начальных элементов в коллекцию
            emails.Add("alice@example.com");
            emails.Add("bob@example.com");
            emails.Add("charlie@example.com");

            //Попытка добавления дубликата
            Console.WriteLine($"Дубликат alice@example.com добавлен? {emails.Add("alice@example.com")}");

            //Проверка наличия подписчиков
            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {emails.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках {emails.Contains("dave@example.com")}");

            //Новое множество
            HashSet<string> newSubscribers = new HashSet<string>
            {
                "bob@example.com",
                "dave@example.com",
                "eve@example.com"
            };

            HashSet<string> unionSet = new HashSet<string>(emails);
            unionSet.UnionWith(newSubscribers);

            Console.WriteLine($"Состав объединенного множества пользователей:");
            //Объединенный список
            foreach (string subscriber in unionSet)
            {
                Console.WriteLine(subscriber);
            }

            HashSet<string> intersectionSet = new HashSet<string>(emails);
            intersectionSet.IntersectWith(newSubscribers);


            Console.WriteLine($"Состав пересечения множеств:");
            //Пересечение множеств
            foreach (string subscriber in intersectionSet)
            {
                Console.WriteLine(subscriber);
            }

            //Удаление подписчика
            Console.WriteLine($"Подписчик charlie@example.com удален? {unionSet.Remove("charlie@example.com")}");

            //Проверка на подмножетсво
            HashSet<string> testSet = new HashSet<string>
            {
                "bob@example.com",
                "eve@example.com"
            };
            Console.WriteLine($"Является ли testSet подмножетсвом unionSet? {testSet.IsSubsetOf(unionSet)}");

            Console.WriteLine($"Число подписчиков в наборе unionSet: {unionSet.Count}");
            //Очистка набора
            unionSet.Clear();
            Console.WriteLine($"Число подписчиков в наборе unionSet после очистки набора: {unionSet.Count}");

            Console.ReadKey();
        }
    }
}
