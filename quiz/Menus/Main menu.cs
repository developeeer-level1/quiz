using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Menus
{
    internal class Main_menu : IMenu
    {
        private string[] menu = {
                                "╔═══════════════════╗",
                                "║  Sign in          ║",
                                "║  Registration     ║",
                                "║  Exit             ║",
                                "╚═══════════════════╝"
                            };
        private int verticalLoc;
        public Main_menu()
        {
            verticalLoc = (Console.WindowHeight / 2) - menu.Length / 2;
        }
        public void Display()
        {
            for (int i = 0; i<menu.Length;i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - menu[0].Length) / 2, verticalLoc + i);
                Console.WriteLine(menu[i]);
            }
        }

        public int Input()
        {
            int selectedIndex = 1;
            while (true)
            {
                for (int i = 1; i < menu.Length - 1; i++)
                {   
                    Console.SetCursorPosition((Console.WindowWidth - menu[0].Length) / 2 + 17, verticalLoc + i);
                    Console.WriteLine(" ");
                }
                Console.SetCursorPosition((Console.WindowWidth - menu[0].Length) / 2 + 17, verticalLoc + selectedIndex);
                Console.WriteLine("←");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Enter)
                {
                    break;
                }
                if (key == ConsoleKey.UpArrow && selectedIndex != 1)
                    selectedIndex--;
                else if (key == ConsoleKey.DownArrow && selectedIndex != menu.Length - 2)
                    selectedIndex++;
            }
            return selectedIndex;
        }

        public void ClearItself()
        {
            StringBuilder space = new StringBuilder();
            for (int i = 0; i < menu[0].Length; i++)
            {
                space.Append(" ");
            }
            for (int i = 0; i < menu.Length; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - menu[0].Length) / 2, verticalLoc + i);
                Console.Write(space);
            }
        }
    }
}
