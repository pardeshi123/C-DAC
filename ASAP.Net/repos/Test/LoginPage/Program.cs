using Microsoft.Data.SqlClient;

namespace LoginPage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            string connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DemoTest;Integrated Security=True";

            do
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Forgot Password");
                Console.Write("Choose option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegisterUser(connectionString);
                        break;

                    case 2:
                        LoginUser(connectionString);
                        break;

                    case 3:
                        ForgotPassword(connectionString);
                        break;

                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }

                Console.Write("To continue enter y: ");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y');
        }

        // ---------------- Forgot Password ----------------
        private static void ForgotPassword(string connectionString)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string checkQuery = "SELECT COUNT(*) FROM users WHERE Uname=@uname";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@uname", username);

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists == 0)
            {
                Console.WriteLine("Username not found");
                con.Close();
                return;
            }

            Console.Write("Enter New Password: ");
            string newPassword = Console.ReadLine();

            string updateQuery = "UPDATE users SET Password=@pwd WHERE Uname=@uname";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@uname", username);
            cmd.Parameters.AddWithValue("@pwd", newPassword);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Password Reset Successful");

            con.Close();
        }

        // ---------------- Login ----------------
        private static void LoginUser(string connectionString)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            SqlConnection con = new SqlConnection(connectionString);

            string query = "SELECT COUNT(*) FROM users WHERE Uname=@uname AND Password=@pwd";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uname", username);
            cmd.Parameters.AddWithValue("@pwd", password);

            con.Open();
            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
                Console.WriteLine("Login Successful");
            else
                Console.WriteLine("Invalid Username or Password");

            con.Close();
        }

        // ---------------- Register ----------------
        private static void RegisterUser(string connectionString)
        {
            Console.Write("Enter New Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter New Password: ");
            string password = Console.ReadLine();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string checkQuery = "SELECT COUNT(*) FROM users WHERE Uname=@uname";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@uname", username);

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists > 0)
            {
                Console.WriteLine("Username already exists");
                con.Close();
                return;
            }

            string insertQuery = "INSERT INTO users (Uname, Password) VALUES (@uname, @pwd)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@uname", username);
            cmd.Parameters.AddWithValue("@pwd", password);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Registration Successful");

            con.Close();
        }
    }
}
