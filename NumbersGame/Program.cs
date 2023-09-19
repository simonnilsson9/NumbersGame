namespace NumbersGame //Simon Nilsson SUT23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random();
            int number = random.Next(1, 20);

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
                    Console.WriteLine("Tyvärr du gissade för högt, försök igen!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt, försök igen!");
                }

            }

            if (!myBool)
            {
                Console.WriteLine("Tyvärr lyckades du inte gissa talet på 5 försök!");
            }

            Console.ReadKey();
        }
    }
}