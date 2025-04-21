namespace Task10_1_Houses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building simpleBuilding1 = new("Улица Пушкина, дом Колотушкина", 2567.65, 1934);
            MultiBuilding multiBuilding1 = new("3-я ул. Строителей, д. 25, кв. 12", 21586.88, 1958, 16, true);

            //Работа с базовыми классами
            simpleBuilding1.DisplayInfo();
            Console.WriteLine($"Налог:{simpleBuilding1.CalculateTax()}");
            Console.WriteLine(new string('-',20));
            multiBuilding1.DisplayInfo();
            Console.WriteLine($"Налог:{multiBuilding1.CalculateTax()}");
            Console.WriteLine($"Площадь на этаж:{multiBuilding1.AreaPerFloor}");
            Console.WriteLine(new string('-', 20));

            //Upcasting
            Building simpleBuildingUp = multiBuilding1;
            simpleBuildingUp.DisplayInfo(); // переопределение сделано через new - после апкастинга используется метод базового класса
            Console.WriteLine($"Налог:{simpleBuildingUp.CalculateTax()}"); //переопределение сделано через virtual-override - после апкастинга используется метод наследника
            //Console.WriteLine($"Площадь на этаж:{simpleBuildingUp.AreaPerFloor}"); // ошибка компиляции
            Console.WriteLine(new string('-', 20));

            ////Исследование типов от общего к частному
            //Console.WriteLine($"{(simpleBuilding1 is MultiBuilding?"Да":"Нет")}"); //Объект изначально создан как Building и является Building - результат "нет"
            //Console.WriteLine($"{(multiBuilding1 is MultiBuilding ? "Да" : "Нет")}"); //Объект изначально создан как MultiBuilding и является MultiBuilding - результат "да"
            //Console.WriteLine($"{(simpleBuildingUp is MultiBuilding ? "Да" : "Нет")}"); //Объект изначально создан как MultiBuilding и является Building - результат "да"
            ////Сохраняются типы, под которыми элементы были изначально созданы

            ////Исследование типов от частного к общему
            //Console.WriteLine($"{(simpleBuilding1 is Building ? "Да" : "Нет")}"); //Объект изначально создан как Building и является Building - результат "да"
            //Console.WriteLine($"{(multiBuilding1 is Building ? "Да" : "Нет")}"); //Объект изначально создан как MultiBuilding и является MultiBuilding - результат "да"
            //Console.WriteLine($"{(simpleBuildingUp is Building ? "Да" : "Нет")}"); //Объект изначально создан как MultiBuilding и является Building - результат "да"
            ////Элементы-наследники всегда являются объектами исходного типа. Поэтому Upcasting безопасен

            //Downcasting
            if (simpleBuildingUp is MultiBuilding)
            {
                MultiBuilding multiBuildingDwn = (MultiBuilding)simpleBuildingUp;
                multiBuildingDwn.DisplayInfo();
                Console.WriteLine($"Налог:{multiBuildingDwn.CalculateTax()}");
                Console.WriteLine($"Площадь на этаж:{multiBuildingDwn.AreaPerFloor}");
                Console.WriteLine(new string('-', 20));

            }
        }

        public class Building
        {
            protected string _adress;
            protected double _area;
            protected int _yearBuilt;

            public Building(string adress, double area, int yearBuilt)
            {
                Adress = adress;
                Area = area;
                YearBuilt = yearBuilt;
            }

            public string Adress
            {
                get => _adress;
                set
                {
                    if (value == "" || value == null)
                        throw new ArgumentException("Введен пустой адрес");
                    _adress = value;
                }
            }

            public double Area
            {
                get => _area;
                set
                {
                    if (value == 0.0)
                        throw new ArgumentException("Введена нулевая площадь");
                    _area = value;
                }
            }

            public int YearBuilt
            {
                private set
                {
                    _yearBuilt = value;
                }
                get => _yearBuilt;
            }

            public int BuildingAge
            {
                get => DateTime.Now.Year - YearBuilt;
            }

            public virtual decimal CalculateTax()
            {
                return (decimal)Area * 1000;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Адрес: {Adress}, Площадь: {Area}, Год постройки: {YearBuilt}, Возраст: {BuildingAge}");
            }
        }

        public sealed class MultiBuilding : Building
        {
            private int _floors;
            private bool _hasElevator;

            public MultiBuilding(string adress, double area, int yearBuilt, int floors, bool hasElevator)
                : base(adress, area, yearBuilt)
            {
                _floors = floors;
                _hasElevator = hasElevator;
            }
            public int Floors
            {
                get => _floors;
                set
                {
                    if (value < 1)
                        throw new ArgumentException("Некорректная этажность");
                    _floors = value;
                }
            }
            public bool HasElevator
            {
                get => _hasElevator;
                set
                {
                    _hasElevator = value;
                }
            }
            public override decimal CalculateTax()
            {
                if (_hasElevator)
                    return (decimal)((1 + (Floors - 1) * 0.05) * Area * 1000 + 5000);
                return (decimal)((1 + (Floors - 1) * 0.05) * Area * 1000);
            }

            public new void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Число этажей: {Floors}, Наличие лифта: {(HasElevator?"Да":"Нет")}");
            }

            public double AreaPerFloor
            {
                get => Area / Floors;
            }
        }
    }
}
