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
            // loop to keep the program running
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Single");
                Console.WriteLine("2. Multiple");
                Console.WriteLine("3. echo x10");
                Console.WriteLine("4. third word");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        // exits the program
                        boolean = false;
                        return;
                    case "1":
                        // asks if the person is a pensioner or youth
                        Console.Write("Pensioner or youth?");
                        PensionerOrYouth();
                        break;
                    case "2":
                        // calculates the total amount of tickets and total price
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
                    case "3":
                        // writes a word 10 times
                        Console.Write("Enter a word: ");
                        string? word = Console.ReadLine();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write($"{word}. ");
                        }
                        break;
                    case "4":
                        // writes the third word of a sentence
                        Console.Write("Enter a sentence: ");
                        string sentence = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(sentence))
                        {
                            Console.WriteLine("Invalid sentence");
                            break;
                        }                         
                        var third = sentence.Split(" ");
                        if (string.IsNullOrEmpty(third[2]))
                        {
                            Console.WriteLine("Invalid sentence");
                            break;
                        } 
                        if (third.Length >= 3)
                        {
                            Console.WriteLine($"Third word: {third[2]}");
                        }
                        else
                        {
                            Console.WriteLine("Sentence does not contain 3 words");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        public static int PensionerOrYouth()
        {
            Console.WriteLine("Age: ");
            // tries to parse the input to an integer
            if (int.TryParse(Console.ReadLine(), out var age))
            {
                if (age < 5 || age > 100)
                {
                    Console.WriteLine("Free ticket");
                    return 0;
                }
                if (age < 20)
                // checks if the age is less than 20 and prints the corresponding price
                {
                    Console.WriteLine("Youth price: 80kr");
                    return 80;
                }
                else if (age > 64)
                // checks if the age is more than 64 and prints the corresponding price
                {
                    Console.WriteLine("Pensioner price: 90kr");
                    return 90;
                } else
                {
                    Console.WriteLine("Standard price: 120kr");
                    return 120;
                }
            }
            else
            {
                Console.WriteLine("Invalid age");
                return 0;
            }
        }
    }
}
