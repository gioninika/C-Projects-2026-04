namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool resume = true;

            while (resume)
            {
                int number = rand.Next(1, 101);
                bool isincorrect = true;
                int attempts = 0;

                Console.WriteLine("gamoicani ricxvi 1 dan 100 mde!");

                while (isincorrect)
                {
                    Console.Write("sheiyvane sheni varaundi: ");
                    int guess = int.Parse(Console.ReadLine());

                    attempts++;
                    if (guess > number)
                    {
                        Console.WriteLine("dabalia!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("magalia!");
                    }
                    else
                    {
                        Console.WriteLine($"gilocav! sworad gamoicani {attempts} mcdelobashi!");
                        isincorrect = false;
                    }
                }

                bool choiceresume = true;
                while (choiceresume)
                {
                    Console.WriteLine("ginda tavidan? (Y/N):");
                    string choice = Console.ReadKey().KeyChar.ToString().ToUpper();
                    Console.WriteLine();

                    if (choice == "Y")
                    {
                        Console.Clear();
                        choiceresume = false;
                    }
                    else if (choice == "N")
                    {
                        Console.WriteLine("programa dasrulda.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("shecdoma: daawire mxolod Y an N.");
                    }
                }
            }
        }
    }
}
