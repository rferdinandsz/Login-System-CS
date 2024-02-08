using System.Data.SqlClient;

namespace Sliit_proj
{
    internal static class Program
    {
        public static string connectionString = "Data Source=DESKTOP-111L5IR\\SQLEXPRESS;Initial Catalog=test;Integrated Security=true";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }

        public static void registerUser(string username, string password, string email, string firstname, string lastname)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO users (username, hashed_password, email, first_name, last_name) VALUES (@Username, @HashedPassword, @Email, @FirstName, @LastName)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@HashedPassword", HashPassword(password));
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@FirstName", firstname);
                    command.Parameters.AddWithValue("@LastName", lastname);

                    int isDone = command.ExecuteNonQuery();

                    if(isDone > 0)
                    {
                        MessageBox.Show("Registered !");
                    } else
                    {
                        MessageBox.Show("Registration Error Occured");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
        }
    }
}