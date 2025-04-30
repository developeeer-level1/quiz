using quiz.Menus;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;


namespace quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreationStartContent();
            Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.UTF8;
            MenuManager.StartMune();
            Console.Clear();
            Console.ReadLine();
        }

        static public void CreationStartContent()
        {
            if (!File.Exists("users.json"))
            {
                using (FileStream file = File.Create("users.json")) { }
            }
            if (!File.Exists("quizzes.json"))
            {
                using (FileStream file = File.Create("quizzes.json")) { }
            }
            List<Question> questions = new List<Question>
            {
                new Question("What is 2 + 2?", new List<string> { "3", "4", "5" }, new List<int> {2}),
                new Question("Select the even numbers:", new List<string> { "1", "2", "3", "4" }, new List<int> {2, 4}),
                new Question("What is the square root of 16?", new List<string> { "2", "4", "8" }, new List<int> {2}),
                new Question("Select the prime numbers:", new List<string> { "2", "4", "5", "9" }, new List<int> {1, 3}),
                new Question("Solve the equation: x + 3 = 7", new List<string> { "4", "5", "3" }, new List<int> {1}),
                new Question("Which numbers are divisible by 5?", new List<string> { "10", "12", "15", "17" }, new List<int> {1, 3}),
                new Question("How many sides does a hexagon have?", new List<string> { "5", "6", "7" }, new List<int> {2}),
                new Question("Solve: 5 * 3", new List<string> { "15", "10", "20" }, new List<int> {1}),
                new Question("Which numbers are divisible by 3?", new List<string> { "6", "7", "9", "11" }, new List<int> {1, 3}),
                new Question("How many degrees are in a right angle?", new List<string> { "45", "90", "180" }, new List<int> {2}),
                new Question("Solve: 12 / 4", new List<string> { "2", "3", "4" }, new List<int> {2}),
                new Question("Which of these numbers are perfect squares?", new List<string> { "9", "16", "20" }, new List<int> {1, 2}),
                new Question("What is 10 - 7?", new List<string> { "1", "2", "3" }, new List<int> {3}),
                new Question("Solve: (2 + 3) * 2", new List<string> { "10", "8", "12" }, new List<int> {1}),
                new Question("Which of these numbers are odd?", new List<string> { "2", "3", "4", "5" }, new List<int> {2, 4}),
                new Question("What is 3^2?", new List<string> { "6", "9", "12" }, new List<int> {2}),
                new Question("How many millimeters are in a centimeter?", new List<string> { "10", "100", "1000" }, new List<int> {1}),
                new Question("Select fractions greater than 0.5:", new List<string> { "1/4", "2/3", "3/5" }, new List<int> {2, 3}),
                new Question("Solve: 100 - 99", new List<string> { "0", "1", "2" }, new List<int> {2}),
                new Question("Which numbers are even?", new List<string> { "1", "2", "3", "4" }, new List<int> {2, 4})
            };
            Quiz math = new Quiz("Math", questions);
            string userInfo = JsonSerializer.Serialize(math);
            using (StreamWriter writer = new StreamWriter("quizzes.json", true))
            {
                writer.WriteLine(userInfo);
            }
        }
    }
}