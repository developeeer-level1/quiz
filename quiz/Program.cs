using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] menu = {
                                "╔════════╗",
                                "║        ║",
                                "╚════════╝"
                            };
            foreach (string line in menu)
            {
                int left = (Console.WindowWidth - (line.Length/2)) / 2;
                Console.SetCursorPosition(left < 0 ? 0 : left, Console.CursorTop);
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
