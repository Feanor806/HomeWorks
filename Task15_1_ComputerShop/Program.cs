using System.Diagnostics;
using static Task15_1_ComputerShop.Program;

namespace Task15_1_ComputerShop
{
    internal class Program
    {

        public class Computer
        {
            public int Id { set; get; }
            public string? Mark { set; get; }
            public string? Processor { set; get; }
            public int RamVolume { set; get; }
            public int HddVolume { set; get; }
            public int VramVolume { set; get; }
            public decimal Price { set; get; }
            public int Count { set; get; }

            public void GetInfo()
            {
                Console.WriteLine(new string('#', 20));
                Console.WriteLine($"Код позиции: {Id}");
                Console.WriteLine($"Марка позиции: {Mark}");
                Console.WriteLine($"Марка процессора: {Processor}");
                Console.WriteLine($"Объем оперативной памяти: {RamVolume/1000} ГБ");
                Console.WriteLine($"Объем жесткого диска: {HddVolume / 1000} ГБ");
                Console.WriteLine($"Объем памяти видеокарты: {VramVolume / 1000} ГБ");
                Console.WriteLine($"Стоимость позиции: {Price}");
                Console.WriteLine($"Количество на складе: {Count}");
                Console.WriteLine(new string('#', 20));
            }

        }
        public static void PrintHeading(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            List<Computer> list = new List<Computer>
            {
                new Computer() {Id = 1, Mark = "MSI Pro DP21 13M-631XRU", Processor = "i5", RamVolume = 16000, HddVolume = 512000, VramVolume = 4000, Price = (decimal)59990.0, Count = 15 },
                new Computer() {Id = 2, Mark = "HP 290 G9 Tower", Processor = "i3", RamVolume = 8000, HddVolume = 512000, VramVolume = 4000, Price = (decimal)57990.0, Count = 25 },
                new Computer() {Id = 3, Mark = "Dell Optiplex 7010 Tower", Processor = "i7", RamVolume = 16000, HddVolume = 512000, VramVolume = 8000, Price = (decimal)72990.0, Count = 13 },
                new Computer() {Id = 4, Mark = "iRU Home 310H6SE", Processor = "i5", RamVolume = 8000, HddVolume = 256000, VramVolume = 2000, Price = (decimal)32990.0, Count = 32 },
                new Computer() {Id = 5, Mark = "iRU Home 310H6SE", Processor = "i5", RamVolume = 32000, HddVolume = 512000, VramVolume = 4000, Price = (decimal)37990.0, Count = 27 },
                new Computer() {Id = 6, Mark = "Acer Gadget ETBox X", Processor = "i3", RamVolume = 16000, HddVolume = 512000, VramVolume = 2000, Price = (decimal)32990.0, Count = 11 },
                new Computer() {Id = 7, Mark = "RASKAT Strike 520190430", Processor = "i7", RamVolume = 32000, HddVolume = 256000, VramVolume = 8000, Price = (decimal)69990.0, Count = 5 },
                new Computer() {Id = 8, Mark = "BLOODY BD-PC CB76C2", Processor = "i9", RamVolume = 32000, HddVolume = 1024000, VramVolume = 12000, Price = (decimal)131990.0, Count = 2 }
            };

            //Получение позиций с указанным типом процессора
            Console.Write("Введите тип процессора для поиска: ");
            string? processorType = Console.ReadLine();
            var byProcessor = list
                .Where(computer => computer.Processor == processorType);

            PrintHeading($"Позиции с типом процессора {processorType}:");

            foreach (var computer in byProcessor)
            {
                computer.GetInfo();
            }

            //Получение позиций с указанным объемом ОЗУ
            int ramVol = 0;
            do
            {
                Console.Write("Введите требуемый объем ОЗУ: ");
                try
                {
                    ramVol = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный формат записи. Введите объем памяти в байтах.");
                    Console.ResetColor();
                }
            }
            while (ramVol == 0);
            var byRam = list
                .Where(computer => computer.RamVolume >= ramVol);

            PrintHeading($"Позиции с объемом ОЗУ от {ramVol/1000} ГБ и более:");

            foreach (var computer in byRam)
            {
                computer.GetInfo();
            }

            //Сортировка позиций по возрастанию цены

            PrintHeading($"Позиции, отсортированные по возрастанию цены:");

            foreach(var computer in list.OrderBy(computer => computer.Price))
            {
                computer.GetInfo();
            }

            //Группировка позиций по типу процессора

            PrintHeading($"Группировка элементов по типу процессора:");

            var processorGrouping = list
                .GroupBy(computer => computer.Processor)
                .OrderBy(group => group.Key);

            foreach (var group in processorGrouping)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n=== ТИП ПРОЦЕССОРА: {group.Key.ToUpper()} ===");
                Console.ResetColor();

                foreach (var computer in group.OrderBy(p => p.Processor))
                {
                    computer.GetInfo();
                }
            }

            //Самая дорогая позиция
            PrintHeading($"Позиции с самой высокой стоимостью:");

            var maxPrice = list
                .Where(computer => computer.Price == list.Max(p => p.Price));
            foreach (var computer in maxPrice)
            {
                computer.GetInfo();
            }

            //Самая дешевая позиция
            PrintHeading($"Позиции с самой низкой стоимостью:");

            var minPrice = list
                .Where(computer => computer.Price == list.Min(p => p.Price));
            foreach (var computer in minPrice)
            {
                computer.GetInfo();
            }

            //Поиск позиций с количесвом более 30 штук
            PrintHeading($"Позиции с количеством от 30 и более:");

            var manyStaff = list
                .Where(computer => computer.Count >= 30);
            if(manyStaff.Count() < 1)
            {
                Console.WriteLine("Позиций с количеством от 30 и более нет");
            }
            else
            {
                foreach (var computer in manyStaff)
                {
                    computer.GetInfo();
                }
            }
            Console.ReadKey();
        }
    }
}
