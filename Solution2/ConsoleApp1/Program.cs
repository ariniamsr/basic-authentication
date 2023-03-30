class Program
{
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

                Console.Write("Operation: ");
                string operation = Console.ReadLine();

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
                Console.WriteLine("Invalid input. Please try again.");
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

         }
       
        static void ShowUser()
        {
           
            Console.WriteLine("ID");
            Console.WriteLine("Name");           
            Console.WriteLine("Username");       
            Console.WriteLine("Password");
            
              

            Console.ReadLine();
            Console.Clear();

        }

        static void SearchUser()
        {
            Console.WriteLine("==Cari Akun==");
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("ID");
            Console.WriteLine("Name");
            Console.WriteLine("Username");
            Console.WriteLine("Password");
            Console.Clear();

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

            Console.WriteLine("LoginBerhasil");
            Console.Clear();

        }

        static void Exit()
        {
            Console.WriteLine("Exit");
            Console.Clear();
        }
        {
            Console.Clear();    
        }

    }
}













