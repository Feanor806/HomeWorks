namespace Task9_2_BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            Console.WriteLine($"Номер счёта: {account1.AccontNumber}");
            Console.WriteLine($"Состояние счёта: {account1.Balance}");
            try
            {
                account1.Withdraw(100);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                account1.Deposit(0);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            account1.Deposit(100);
            Console.WriteLine($"Состояние счёта: {account1.Balance}");
            account1.Deposit(100);
            Console.WriteLine($"Состояние счёта: {account1.Balance}");
            try
            {
                account1.Withdraw(300);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Состояние счёта: {account1.Balance}");
            account1.Withdraw(150);
            Console.WriteLine($"Состояние счёта: {account1.Balance}");
            Console.ReadKey();
        }

        public class BankAccount
        {
            private decimal _balance;
            static int TotalAccounts = 0;

            public string AccontNumber { get; }

            public decimal Balance
            {
                get => _balance;
                private set
                {
                    _balance = value;
                }
            }

            public BankAccount()
            {
                AccontNumber = Guid.NewGuid().ToString();
                TotalAccounts++;
            }

            public void Deposit(decimal deposit)
            {
                if (deposit <= 0)
                    throw new ArgumentOutOfRangeException("Введенное значение не подходит для зачисления на счёт");
                Balance += deposit;
            }

            public void Withdraw(decimal withdraw)
            {
                if (Balance == 0)
                {
                    throw new ArgumentOutOfRangeException("На счету нет средств");
                }
                if (withdraw > Balance)
                    throw new ArgumentOutOfRangeException("Недостаточно средств");
                Balance -= withdraw;
            }
        }
    }
}
