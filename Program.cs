namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] myNumbers = new int[3]; //ungefär samma som - int num1; int num2; int num3;
            Random random = new Random();
            int secret = random.Next(1,20);

            Console.WriteLine(secret);
            Console.WriteLine("Gissa hemliga talet. Du kan skriva 3 olika tal");

            while (true)
            {
                if (i < 3)
                {
                    Console.WriteLine($"Ange tal {i+1}: ");
                    Console.Write("> ");

                    try
                    {
                        myNumbers[i] = int.Parse(Console.ReadLine());
                        i++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
            int j = 1;
            foreach (int x in myNumbers)
            {
                Console.WriteLine($"Du gissade: {x}");
                if (secret == x)
                {
                    Console.WriteLine($"Gissning {j} var rätt! Du vann!\n");
                    j++;
                    break;
                }
                else
                {
                    Console.WriteLine($"Gissning {j} var tyvärr fel.\n");
                    j++;
                }
            }
        }
    }
}