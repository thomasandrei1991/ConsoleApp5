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
            Console.WriteLine("======================================");

            Console.Write("\nEnter your pin#: ");
            string defaultPin = "1234";
            string inputPin = Console.ReadLine() ?? string.Empty;

            if (inputPin == defaultPin)
            {
                break; // tama PIN → proceed to menu
            }
            else
            {
                Console.WriteLine("\nInvalid pin. Try again.");
                Console.ReadKey();
            }
        }

        // Main Menu Loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine("4. Exit");
            Console.Write("Select option: ");

            string choice = Console.ReadLine() ?? "";

            if (choice == "4")
            {
                Console.WriteLine("Thank you for using XYZ Bank ATM!");
                break; // exit program
            }

            Console.WriteLine("Feature not implemented yet.");
            Console.ReadKey();
        }
    }
}