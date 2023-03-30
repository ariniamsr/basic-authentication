using System;
using System.Security.Cryptography.X509Certificates;

class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public User(string firstName, string lastName, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Password = password;
        UserName = $"{firstName[..2]} {lastName[..2]}";

    }

    public string GetUserData()
    {
        return $"Full Name : {FirstName} {LastName} \n" +
               $"User Name : {UserName} \n" +
               $"Password  : {Password}";
    }
}

class Program
{
    static List<User> users = new List<User>();
    static void Main(string[] args)
    {

        while (true)
        {

            {
                Console.WriteLine("== BASIC AUTHENTICATION ==");
                Console.WriteLine(DateTime.Now.ToString("MM/dd/yy HH:mm:ss"));
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Show User");
                Console.WriteLine("3. Search User");
                Console.WriteLine("4. Login User");
                Console.WriteLine("5. Exit");

                Console.Write("Input: ");
                string operation = Console.ReadLine();
                Console.Clear();

                switch (operation)
                {
                    case "1":
                        CreateUser();
                        break;
                    case "2":
                        ShowUser();
                        break;
                    case "3":
                        SearchUser();
                        break;
                    case "4":
                        LoginUser();
                        break;
                    case "5":
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please try again.");
                        break;
                }


            }
        }

        static void CreateUser()
        {
            Console.WriteLine("CreateUser");
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.WriteLine("\nData user berhasil dibuat\n");

            string UserName = (firstName[..2]) + (lastName[..2]);
            User user = new User(firstName, lastName, password);
            users.Add(user);
            Console.WriteLine("User sudah berhasil ditambahkan");
        }


        static void ShowUser()
        {

            var count = 0;
            foreach (var user in users)
            {
                Console.WriteLine("Id : " + count++);
                Console.WriteLine(user.GetUserData());
                Console.WriteLine("=========================");
            }
            Console.ReadLine();
        }

        static void SearchUser()
        {
            Console.WriteLine("==Cari Akun==");
            Console.Write("Enter first name: ");
            string name = Console.ReadLine();


            foreach (User user in users)
            {
                Console.WriteLine("ID: " + user.UserName);
                Console.WriteLine("Name " + user.FirstName);
                Console.WriteLine("Username " + user.UserName);
                Console.WriteLine("Password " + user.Password);

            }
            Console.ReadLine();

        }

        static void LoginUser()
        {
            Console.WriteLine("LoginUser");
            Console.WriteLine("Username");
            Console.Write("Enter User name: ");
            string Username = Console.ReadLine();

            Console.WriteLine("Password");
            Console.Write("Enter Password: ");
            string Password = Console.ReadLine();

            if (LoginUser != null)
            {
                Console.WriteLine("Login Berhasil ");
            }
            else
            {
                Console.WriteLine("Login Gagal");
            }


        }

        static void Exit()
        {
            Console.WriteLine("Exit");


        }

    }
}
