using System.Text;


namespace StudentSystem.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Repository.StudentRepository sy = new Repository.StudentRepository();

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== სტუდენტების სისტემა ===");
                Console.WriteLine("1. დამატება");
                Console.WriteLine("2. ყველა სტუდენტი");
                Console.WriteLine("3. ძებნა");
                Console.WriteLine("4. შეფასების განახლება");
                Console.WriteLine("5. გასვლა");

                Console.Write("აირჩიე: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.AddStudent();
                        break;
                    case "2":
                        manager.ShowAll();
                        break;
                    case "3":
                        manager.SearchStudent();
                        break;
                    case "4":
                        manager.UpdateGrade();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("არასწორი არჩევანი!");
                        break;
                }
            }
        }
    }
}
