using System.Xml.Serialization;

namespace Menuthings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Enter corresponding number to navigate");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Pensioner or youth");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("You selected option 1");
                        break;
                    case "2":
                        Console.WriteLine("You selected option 2");
                        break;
                    case "3":
                        Console.WriteLine("You selected option 3");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
