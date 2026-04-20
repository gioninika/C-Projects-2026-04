using System.Text;

namespace Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\nაირჩიე თარგმნის მიმართულება:");
                Console.WriteLine("1. ქართული -> ინგლისური");
                Console.WriteLine("2. ინგლისური -> ქართული");
                Console.WriteLine("3. ქართული -> რუსული");
                Console.WriteLine("4. რუსული -> ქართული");
                Console.WriteLine("0. გამოსვლა");

                string choice = Console.ReadLine();

                string fileName = choice switch
                {
                    "1" => "ka-en.txt",
                    "2" => "en-ka.txt",
                    "3" => "ka-ru.txt",
                    "4" => "ru-ka.txt",
                    _ => null
                };

                if (fileName == null)
                {
                    Console.WriteLine("არასწორი არჩევანი!");
                    continue;
                }

                Dictionary<string, string> dictionary = LoadDictionary(fileName);

                Console.Write("\nშეიყვანე სიტყვა: ");
                string input = Console.ReadLine().ToLower();

                if (dictionary.ContainsKey(input))
                {
                    Console.WriteLine("თარგმანი: " + dictionary[input]);
                }
                else
                {
                    Console.WriteLine("სიტყვა ვერ მოიძებნა ლექსიკონში.");

                    Console.Write("გსურს დაამატო თარგმანი? (y/n): ");
                    string add = Console.ReadLine().ToLower();

                    if (add == "y")
                    {
                        Console.Write("შეიყვანე თარგმანი: ");
                        string translation = Console.ReadLine();

                        AddToDictionary(fileName, input, translation);
                        Console.WriteLine("დამატებულია!");
                    }
                }
            }
        }

        static Dictionary<string, string> LoadDictionary(string fileName)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            string[] lines = File.ReadAllLines($"../../../{fileName}");

            foreach (string line in lines)
            {
                string[] parts = line.Split('-');
                if (parts.Length == 2)
                {
                    dict[parts[0].Trim().ToLower()] = parts[1].Trim();
                }
            }

            return dict;
        }

        static void AddToDictionary(string fileName, string word, string translation)
        {
            using (StreamWriter sw = File.AppendText($"../../../{fileName}"))
            {
                sw.WriteLine($"{word} - {translation}");
            }

            string[] parts = fileName.Replace(".txt", "").Split('-');
            string reversed = $"{parts[1]}-{parts[0]}.txt";

            using (StreamWriter sw2 = File.AppendText($"../../../{reversed}"))
            {
                sw2.WriteLine($"{translation} - {word}");
            }
        }
    }
}
