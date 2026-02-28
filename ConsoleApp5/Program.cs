using System.Text;

class Program
{
    private static void Main(string[] args)
    {
        // PIN Verification Loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("        Welcome to XYZ Bank ATM");
            Console.WriteLine("======================================\n");
            Console.Write("\nEnter your pin# : ");
            
            string defaultPin = "1234";
            string inputPin = ReadPin();

            if (inputPin == defaultPin)
            {
                Console.WriteLine("\n\nPin accepted. Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                // Show main menu. When MainMenu returns, control goes back to the PIN loop.
                MainMenu();
            }
            else
            {
                Console.WriteLine("\nInvalid pin. Try again.");
                Console.ReadKey();
            }
        }
    }
    // Password security method (****)
    static string ReadPin()
    {
        StringBuilder pin = new StringBuilder();

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
                break;

            if (key.Key == ConsoleKey.Backspace && pin.Length > 0)
            {
                pin.Remove(pin.Length - 1, 1);
                Console.Write("\b \b");
            }
            else if (!char.IsControl(key.KeyChar))
            {
                pin.Append(key.KeyChar);
                Console.Write("*");
            }
        }

        return pin.ToString();
    }
    // Main Menu
    private static void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("              Main Menu");
            Console.WriteLine("======================================\n");
            Console.WriteLine("\nHello, George\n");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine("4. Change PIN");
            Console.WriteLine("5. Exit");
            Console.Write("\nEnter choice : ");

            string choice = Console.ReadLine() ?? "";
            if (choice == "3")
            {
                Console.Clear();
                DepositCash();
            }
            if (choice == "5")
            {
                return;
            }

        }
    }
    private static void DepositCash()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("              Deposit Cash");
        Console.WriteLine("======================================\n");
        double currentBalance = 1000.00; // initial balance
        while (true)
        {
            Console.Write("Enter cash amount : ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            currentBalance += depositAmount;
            Console.WriteLine(depositAmount + " deposited successfully.");
            Console.WriteLine("Current Balance : " + currentBalance);
            Console.WriteLine();
            Console.Write("Do you want to continue (y/n) : ");
            string continueChoice = Console.ReadLine() ?? "";
            if (continueChoice == "y")
            {
                continue;
            }
            else
            {
                Console.Clear();
                return;
            }

        }
    }
}