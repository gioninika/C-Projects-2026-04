using StudentSystem.Repository;
using StudentSystem.Repository.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace StudentSystem.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            StudentRepository sy = new StudentRepository();


            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== სტუდენტების სისტემა ===");
                Console.WriteLine("1. დამატება");
                Console.WriteLine("2. ყველა სტუდენტი");
                Console.WriteLine("3. ძებნა");
                Console.WriteLine("4. შეფასების განახლება");
                Console.WriteLine("0. გასვლა");
                //Console.Write("აირჩიე: ");
                //string choice = Console.ReadLine();
                string choice = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("შეიყვანეთ სტუდენტის სახელი: ");
                        string name = Console.ReadLine();
                        Console.Write("შეიყვანეთ სტუდენტის ნიშანი: ");
                        char grade = char.Parse(Console.ReadLine());
                        Task<int> result = sy.AddStudentAsync(new Student { Name = name, Grade = grade });
                        Console.WriteLine($"ახალი მოსწავლე შექმნილია, მისი ნომერი: {result.Result}");
                        break;
                    case "2":
                        List<Student> students = sy.GetStudents();
                        foreach (var x in students)
                        {
                            Console.WriteLine($"სახელი: {x.Name}, ნომერი: {x.RollNumber}, ნიშანი: {x.Grade}");
                        }
                        break;
                    case "3":
                        Console.Write("შეიყვანეთ სტუდენტის ნომერი: ");
                        int rollNumber = int.Parse(Console.ReadLine());
                        Student student = sy.GetSingleStudent(rollNumber);
                        if (student != null)
                        {
                            Console.WriteLine($"სახელი: {student.Name}, ნომერი: {student.RollNumber}, ნიშანი: {student.Grade}");
                        }
                        else
                        {
                            Console.WriteLine("სტუდენტი ვერ მოიძებნა.");
                        }
                        break;
                    case "4":
                        Console.Write("შეიყვანეთ სტუდენტის ნომერი: ");
                        int rollNumber2 = int.Parse(Console.ReadLine());
                        Console.Write("შეიყვანეთ სტუდენტის ნიშანი: ");
                        char grade2 = char.Parse(Console.ReadLine());
                        Task<Student> result2 = sy.UpdateStudentGradeAsync(rollNumber2, grade2);
                        Console.WriteLine($"სტუდენტის ინფორმაცია განახლდა: სახელი: {result2.Result.Name}, ნიშანი: {result2.Result.Grade}");
                        break;
                    case "0":
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
