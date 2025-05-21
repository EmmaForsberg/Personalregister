namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var register = new PersonalRegister();
            bool running = true;

            while (running)
            {
                PrintStartMenu();
                var inputchoise = Console.ReadLine();

                switch (inputchoise)
                {
                    case "1":
                        Console.WriteLine("Skriv in ditt namn och lön separerat med mellanslag:");
                        var input = Console.ReadLine();
                        if (!register.TryAddEmployee(input))
                        {
                            Console.WriteLine("Felaktig input. Försök igen (ex: Anna 30000).");
                        }
                        break;
                    case "2":
                        register.PrintEmployees();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }

            static void PrintStartMenu()
            {
                Console.WriteLine("1. Lägg till anställd");
                Console.WriteLine("2. Skriv ut register");
                Console.WriteLine("3. Avsluta");
            }
        }
    }
}
