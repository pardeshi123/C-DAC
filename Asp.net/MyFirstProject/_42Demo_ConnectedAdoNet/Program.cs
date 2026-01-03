using Microsoft.Data.SqlClient;

namespace _42Demo_ConnectedAdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = " Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True;";
            #region SELECT QUERY 

            SqlConnection con = new SqlConnection(connectionString);

            string selectQuery = "SELECT * FROM Emp";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = selectQuery;
            cmd.Connection = con;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string? nm = reader["Name"].ToString();
                string? address = reader["Address"].ToString();
                Console.WriteLine($"Id:{id}, Name: {nm}, Address: {address}");
            }

            con.Close();


            #endregion

        }
    }
}
