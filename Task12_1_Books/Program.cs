namespace Task12_1_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] FistArray =
            [
                new Book<string, int>("F-1234", "Дюна", 1965, "Фрэнк Герберт"),
                new Book<string, int>("F-5678", "Гарри Поттер и филосовский камень", 1997, "Джоан Роулинг"),
            ];

            Book<int, string>[] SecondArray =
            [
                new Book<int, string>(42, "Властелин Колец", "1937-1949", "Дж. Р. Р. Толкин"),
                new Book<int, string>(57, "Песнь льда и пламени", "1999-н.в.", "Джордж Мартин"),
            ];

            Book<string, int> book1 = FindBook(FistArray, "F-1234");
            Book<int, string> book2 = FindBook(SecondArray, 42);

            Console.WriteLine(book1?.ToString() ?? "Книга не найдена");
            Console.WriteLine(book2?.ToString() ?? "Книга не найдена");

            Console.ReadKey();
        }
        public static Book<T,U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (Book<T, U> book in books)
            {
                if (book.Code.Equals(code))
                {
                    return book;
                }
            }
            return null;
        }

    }

    public class Book<T, U>
    {
        public T Code { get; set; }
        public string Title { get; set; }
        public U PublicationYear { get; set; }
        public string Author { get; set; }

        public Book (T code, string title, U year, string author)
        {
            Code = code;
            Title = title;
            PublicationYear = year;
            Author = author;
        }

        public override string ToString()
        {
            return $"{(T)Code}, Название: {Title}, Автор: {Author}, Год: {(U)PublicationYear}";
        }
    }
}

