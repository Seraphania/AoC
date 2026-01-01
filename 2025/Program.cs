using System;
using System.Reflection;
using System.Text;


namespace _2025
{
    interface ISolution
    {
        void Run(List<String> input);
    }

    public class SolutionAttribute : Attribute
    {
        public string Day { get; set; }
        public string Description { get; set; }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Type[] classes = typeof(ISolution).Assembly.GetTypes();
            classes = Array.FindAll(classes, _class => _class.IsClass && _class.IsAssignableTo(typeof(ISolution)));

            var solutions = new Dictionary<string, (ISolution Solution, string Display)>();
            
            Array.ForEach(classes, _class =>
            {
                SolutionAttribute attrib = _class.GetCustomAttribute<SolutionAttribute>();
                string day = _class.Name;
                string description = _class.Name;
                if (attrib != null)
                {
                    day = attrib.Day;
                    description = attrib.Description;
                }
                ISolution toRun = (ISolution)Activator.CreateInstance(_class);
                solutions.Add(day, (toRun, description));
            });

            var reader = new FileReader();

            ShowMenu();
            string input = ValidateInput(NormaliseInput(Console.ReadLine()!));

            while (input != "exit")
            { 
                try
                {
                    var inputData = reader.LoadInput($"day{input.Split('.')[0]}");
                    solutions[input].Solution.Run(inputData);
                }
                catch (FileNotFoundException ex)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                Console.Write("\n\nPress any key to return to the menu... ");
                Console.ReadKey(true);
                Console.Clear();
                ShowMenu();
                input = ValidateInput(NormaliseInput(Console.ReadLine()!));
            }

            string NormaliseInput(string s) => s.Trim().ToLower();

            void ShowMenu()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.Write("* {1}*{1} *~ ", 15, (char)15);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Adevent of Code 2025");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" ~* {1}*{1} *", 15, (char)15);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nAVAILABLE SOLUTIONS:\n\nOption\t: Description");
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var item in solutions)
                {
                    Console.WriteLine($"{item.Key}\t: {item.Value.Display}");
                }
                Console.Write("Please select an option or 'exit': > ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            string ValidateInput(string input)
            {
                while (input != "exit" && !solutions.ContainsKey(input))
                {
                    Console.Clear();
                    ShowMenu();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n\n'{input}' is not a valid option, please select another...\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(37, solutions.Count +3);
                    input = NormaliseInput(Console.ReadLine()!);
                    Console.Clear();
                }
                return input;
            }

        }
    }
}
