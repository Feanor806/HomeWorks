namespace Task9_1_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new("Война и мир", "Л.Толстой", 1869, 1225);
            Book book2 = new("Властелин колец", "Дж.Р.Р.Толкин", 1937, 752);
            Console.WriteLine(book1.GetInfo());
            Console.WriteLine(book2.GetInfo());
            Console.ReadKey();
        }

        public class Book
        {
            //Поля
            private string _title;
            private string _author;

            //Автосвойства
            public int Year { get; set; }
            public int Pages { get; set; }

            public static int BookIterator = 0;

            public string Title
            {
                get => _title;
                set
                {
                    if(value == "")
                    {
                        throw new ArgumentException("Заголовок является пустой строкой");
                    }
                    else if(value == null)
                    {
                        throw new ArgumentNullException("Заголовок книги является NULL");
                    }
                        _title = value;
                }
            }
            public string Author
            {
                get => _author;
                set
                {
                    if (value == "")
                    {
                        throw new ArgumentException("Автор является пустой строкой");
                    }
                    else if (value == null)
                    {
                        throw new ArgumentNullException("Автор книги является NULL");
                    }
                    _author = value;
                }
            }

            public Book(string title, string author, int year, int pages)
            {
                Title = title;
                Author = author;
                Year = year;
                Pages = pages;
                BookIterator++;
            }
            static Book()
            {
                Console.WriteLine("Инициализация библиотеки...");
            }

            public string GetInfo()
            {
                return $"Информация о книге: Автор: {Title}, Заголовок: {Author}, Год издания: {Year}, Кол-во страниц: {Pages}";
            }
        }
    }
}
