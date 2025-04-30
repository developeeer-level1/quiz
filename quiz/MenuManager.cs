using quiz.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    static internal class MenuManager
    {
        static private IMenu currentMenu;
        static public void StartMune()
        {
            if(currentMenu != null)
            {
              currentMenu.ClearItself();
            }
            currentMenu = new Main_menu();
            currentMenu.Display();
            int choice = currentMenu.Input();
            switch (choice)
            {
                case 1:
                    if (User_manager.Authorization())
                    {
                        currentMenu.ClearItself();
                        ProgMenu();
                    }
                    break;
                case 2:
                    User_manager.Registration();
                    break;
                case 3:
                    Environment.Exit(0);
                    return;
            }
        }
        static public void RegistrateMenu()
        {
            currentMenu.ClearItself();
            currentMenu = new Registration_menu();
            currentMenu.Display();
            int choice = currentMenu.Input();
            switch (choice)
            {
                case 1:
                    ProgMenu();
                    break;
                case 2:
                    User_manager.Registration();
                    break;
                case 3:
                    StartMune();
                    return;
            }
        }
        static public void ProgMenu()
        {
            currentMenu.ClearItself();
            currentMenu = new Prog_mune();
            currentMenu.Display();
            int choice = currentMenu.Input();
            switch (choice)
            {
                case 1:
                    if (User_manager.Authorization())
                    {
                        ProgMenu();
                    }
                    break;
                case 2:
                    User_manager.Registration();
                    break;
                case 3:
                    StartMune();
                    return;
            }
        }
        static void LogoPrint()
        {
            string[] menu = {
                                "║        Quaestio        ║",
                                "╚════════════════════════╝"
                            };
            for (int i = 0; i < menu.Length; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - menu[0].Length) / 2, Console.CursorTop);
                Console.WriteLine(menu[i]);
            }
        }
    }
}
