namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize variables and ask for user input.
            int guesses = 5;
            int userInput = 0;
            Random random = new Random();
            int secret = random.Next(1,21);

            Console.WriteLine("Välkommen! Jag tänker på ett tal mellan 1 och 20. Kan du gissa vilket? Du får fem försök.");
            Console.Write("> ");
            while (true)
            {
                //call method to handle input error
                userInput = ErrorHandling(userInput);
                guesses--;

                //compare user input to secret number and loop until user guess correctly or run out of attempts
                if (userInput < secret && guesses > 0)
                {
                    Console.WriteLine($"Du gissade för lågt! Du har {guesses} gissningar kvar.");
                }
                else if (userInput > secret && guesses > 0)
                {
                    Console.WriteLine($"Du gissade för högt! Du har {guesses} gissningar kvar.");
                }
                else if (guesses == 0)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }
                Console.Write("> ");
            }
        }
        //simple method to handle user input error
        static int ErrorHandling(int i)
        {
            while (true)
            {
                try
                {
                    i = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Du måste ange ett tal, försök igen!");
                    Console.Write("> ");
                }
            }
            return i;
        }
    }
}