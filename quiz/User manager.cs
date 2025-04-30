using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace quiz
{
    internal static class User_manager
    {
        static public User CurrentUser { get; set; }
        public static void Registration()
        {
            string name = "";
        FillingName:
            while (true)
            {
                bool isExistName = false;
                Console.WriteLine("Введите имя: ");
                name = Console.ReadLine();
                if (name == "/back")
                {
                    MenuManager.StartMune();
                    return;
                }
                string nn;
                using (StreamReader reader = new StreamReader("users.json"))
                {
                    while ((nn = reader.ReadLine()) != null)
                    {
                        User tempUser = JsonSerializer.Deserialize<User>(nn);
                        if (tempUser.Name == name)
                        {
                            Console.WriteLine("This name alredy exist, try other variant");
                            isExistName = true;
                            break;
                        }
                    }
                    if (!isExistName)
                    {
                        break;
                    }
                }
            }
            FillingPassword:
            Console.WriteLine("Введите пароль: ");
            string password;
            password = Console.ReadLine();
            if (password == "/back")
            {
                goto FillingName;
            }
                
            Console.WriteLine("Введите дату рождения (например, 01.01.2000): ");
            string birthDate = Console.ReadLine();
            while (!DateTime.TryParse(birthDate, out DateTime date))
            {
                if (birthDate == "/back")
                {
                    goto FillingPassword;
                }
                Console.WriteLine("Неверный формат. Попробуйте ещё раз:");
                birthDate=Console.ReadLine();
            }
            CurrentUser = new User() { Name = name, Password = password, BirthDate = birthDate };
            string userInfo = JsonSerializer.Serialize(CurrentUser);
            using (StreamWriter writer = new StreamWriter("users.json", true))
            {
                writer.WriteLine(userInfo);
            }
            MenuManager.RegistrateMenu();
        }
        public static bool Authorization()
        {
            while (true)
            {
                string nn;
                using (StreamReader reader = new StreamReader("users.json"))
                {
                    Console.Write("Введите имя: ");
                    string name = Console.ReadLine();
                    while ((nn = reader.ReadLine()) != null)
                    {
                        User tempUser = JsonSerializer.Deserialize<User>(nn);
                        if (tempUser.Name == name)
                        {
                            while (true)
                            {
                                Console.Write("Введите пароль: ");
                                string password = Console.ReadLine();
                                if (tempUser.Password == password)
                                {
                                    CurrentUser=tempUser;
                                    return true;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong! Try again");
                                }
                            }
                        }
                    }
                    Console.WriteLine("This name does not exist, try another one");
                }
            }
        }
    }
}
