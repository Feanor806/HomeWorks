namespace Block14_2_SmartHouse
{
    internal class Program
    {
        delegate void DeviceStateChanged(string device, string state);
        static void Main(string[] args)
        {
            SmartHomeSystem smartHome = new();

            smartHome.StateChanged += (unit, state) =>
            {
                if (state == "Включен" || state == "Заперта")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if(state == "Выключен" || state == "Открыта")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] - {unit}: {state}");
                Console.ResetColor();
            };

            smartHome.TurnOnLight();
            smartHome.TurnOnLight();
            smartHome.TurnOffLight();
            smartHome.UnlockDoors();
            smartHome.LockDoors();
            smartHome.UnlockDoors();
            smartHome.SetTemperature(20);
            smartHome.SetTemperature(25);

        }

        class SmartHomeSystem
        {
            public event DeviceStateChanged StateChanged;

            bool _lightsOn = false;
            int _temperature = 20;
            bool _doorsLocked = false;

            public void TurnOnLight()
            {
                if (!_lightsOn)
                {
                    _lightsOn = true;
                    StateChanged?.Invoke("Свет", "Включен");
                }
                else
                {
                    Console.WriteLine("Свет уже включен!");
                }
            }
            public void TurnOffLight()
            {
                if (_lightsOn)
                {
                    _lightsOn = false;
                    StateChanged?.Invoke("Свет", "Выключен");
                }
                else
                {
                    Console.WriteLine("Свет уже выключен!");
                }
            }
            public void LockDoors()
            {
                if (!_doorsLocked)
                {
                    _doorsLocked = true;
                    StateChanged?.Invoke("Дверь", "Заперта");
                }
                else
                {
                    Console.WriteLine("Дверь уже заперта!");
                }
            }
            public void UnlockDoors()
            {
                if (_doorsLocked)
                {
                    _doorsLocked = false;
                    StateChanged?.Invoke("Дверь", "Открыта");
                }
                else
                {
                    Console.WriteLine("Дверь уже открыта!");
                }
            }
            public void SetTemperature(int temp)
            {
                if (_temperature != temp)
                {
                    _temperature = temp;
                    StateChanged?.Invoke("Термостат", $"Температура установлена на {temp} град.");
                }
                else
                {
                    Console.WriteLine($"Термостат уже утсановлен на {temp} град.!");
                }
            }
        }
    }
}
