namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool resume = true;
                while (resume)
                {
                    List<string> words = new List<string>()
                    {
                        "apple", "banana", "computer", "school", "keyboard"
                    };

                    Random rand = new Random();
                    string word = words[rand.Next(words.Count)];

                    char[] guessed = new char[word.Length];
                    for (int i = 0; i < guessed.Length; i++)
                    {
                        guessed[i] = '_';
                    }

                    int attempts = 6;
                    bool won = false;

                    Console.WriteLine("mogesalmebit HangMan shi (sityvebi inglisuria)!");

                    while (attempts > 0)
                    {
                        Console.WriteLine("\nsityva: " + string.Join(" ", guessed));
                        Console.WriteLine("darchenili Shesadzlebeloba: " + attempts);
                        Console.Write("Sheiyvane aso: ");

                        char letter = Convert.ToChar(Console.ReadLine());
                        bool found = false;

                        for (int i = 0; i < word.Length; i++)
                        {
                            if (word[i] == letter)
                            {
                                guessed[i] = letter;
                                found = true;
                            }
                        }

                        if (!found)
                        {
                            attempts--;
                            Console.WriteLine("arasworia!");
                        }

                        if (new string(guessed) == word)
                        {
                            won = true;
                            break;
                        }
                    }

                    if (won)
                    {
                        Console.WriteLine("\nshen moige! Sityva: " + word);
                        resume = false;
                    }
                    else
                    {
                        Console.WriteLine("\nshen waage! Sityva: " + word);
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
