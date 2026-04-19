namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool resume = true;
            while (resume)
            {
                double num1;
                double num2;
                string operation;

                Console.WriteLine("sheiyvane pirveli ricxvi:");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("sheiyvane meore ricxvi:");
                num2 = Convert.ToDouble(Console.ReadLine());

                // ოპერაციის ვალიდაცია
                while (true)
                {
                    Console.WriteLine("airchie operacia (+, -, *, /):");
                    operation = Console.ReadLine();

                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                        break;

                    Console.WriteLine("shecdoma: araswori operacia! scade tavidan.");
                }

                double result;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"shedegi: {result}");
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"shedegi: {result}");
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"shedegi: {result}");
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("nulze gayopa ar sheidzleba!");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine($"shedegi: {result}");
                        }
                        break;
                }
                bool choiceresume = true;
                while (choiceresume)
                {
                    Console.WriteLine("ginda tavidan? (Y/N):");
                    string choice = Console.ReadLine().ToUpper();

                    if (choice == "Y")
                    {
                        Console.Clear();
                        choiceresume = false;
                    }
                    else if (choice == "N")
                    {
                        Console.WriteLine("programa dasrulda.");
                        //resume = true;
                        //choiceresume = false;
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
