using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace NumbersGame //Simon Nilsson SUT23
{
    internal class Program
    {            
        static void Main(string[] args)
        {            
            RunGame();
            PlayAgain();                                    
        }
       
        public static void RunGame()
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            int number = random.Next(1, 21);

            bool myBool = false;

            for (int i = 1; i <= 5; i++)
            {
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine($"Woho! Du gjorde det! Det tog dig {i} försök att gissa rätt!");
                    myBool = true;
                    break;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
            }
            if (!myBool)
            {
                Console.WriteLine("\nTyvärr lyckades du inte gissa talet på 5 försök!");
            }

        }
        public static void PlayAgain()
        {
            bool play = true;
            while (play)
            {
                Console.WriteLine("\nVill du spela igen? Ja/Nej");
                string input = Console.ReadLine().ToLower();
                if (input == "ja")
                {
                    Console.Clear();
                    RunGame();
                }
                else if (input == "nej")
                {
                    Console.Clear();
                    Console.WriteLine("Tack för denna gången! Tryck ENTER för att stänga ner programmet.");
                    play = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val. Försök igen!");
                }
            }

        }
    }
}