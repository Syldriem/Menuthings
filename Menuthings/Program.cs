using System.Xml.Serialization;

namespace Menuthings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Enter corresponding number to navigate");

            var boolean = true;
            while (boolean)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Single");
                Console.WriteLine("2. Multiple");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        boolean = false;
                        return;
                    case "1":
                        Console.Write("Pensioner or youth?");
                        PensionerOrYouth();
                        break;
                    case "2":
                        Console.Write("Number of attendants: ");
                        int.TryParse(Console.ReadLine(), out int attendantsNr);
                        int amount = 0;
                        for (int i = 0; i < attendantsNr; i++)
                        {
                            amount += PensionerOrYouth();
                        }
                        Console.WriteLine($"Number of attendants: {attendantsNr}");
                        Console.WriteLine($"Total amount: {amount}kr");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        public static int PensionerOrYouth()
        {
            int amount = 0;
            Console.WriteLine("Age: ");
            if (int.TryParse(Console.ReadLine(), out var age))
            {
                if (age < 20)
                {
                    Console.WriteLine("Youth price: 80kr");
                    return amount = 80;
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensioner price: 90kr");
                    return amount = 90;
                } else
                {
                    Console.WriteLine("Standard price: 120kr");
                    return amount = 120;
                }
            }
            else
            {
                Console.WriteLine("Invalid age");
                return amount;
            }
        }
    }
}
