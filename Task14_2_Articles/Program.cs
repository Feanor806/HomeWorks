namespace Task14_2_Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание словаря с товарными позициями
            Dictionary<string, int> articles = new();

            //Добавление товаров
            //Ноутбуки
            articles["A001"] = 10;
            //Смартфоны
            articles["B205"] = 25;
            //Наушники
            articles["C307"] = 15;

            //Проверка наличия смартфонов
            Console.WriteLine($"Есть ли товар с артикулом B205? {articles.ContainsKey("B205")}");

            //Продажа двух ноутбуков
            articles["A001"] -= 2;

            //Проверка колмчества наушников
            articles.TryGetValue("C307", out int headphonesCount);
            Console.WriteLine($"Количество наушников: {headphonesCount}");

            //Завоз 5 смартфонов
            articles["B205"] += 5;

            //Удаление наушников
            articles.Remove("C307");

            //Вывод инвентаря
            foreach (string key in articles.Keys)
            {
                Console.WriteLine($"Артикул: {key}, Количество: {articles[key]}");
            }

            //Проверка наличия артикулов
            Console.WriteLine($"Инвентарь пуст? {!(articles.Count > 0)}");

            //Очистка инвентаря
            articles.Clear();

            //Проверка наличия артикулов после очистки
            Console.WriteLine($"Количество товаров после очистки: {articles.Count}");

            Console.ReadKey();
        }
    }
}
