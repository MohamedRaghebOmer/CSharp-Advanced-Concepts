using System;
using Mohamed = System.Console;
using static System.Math;
using System.Data.SqlClient;

internal static class UsingStatements
{
    static void Main(string[] args)
    {
        Mohamed.WriteLine("This is a line.");

        // We are able to use 'Sqrt' without 'Math' class name due to 'using static System.Math;'
        Mohamed.WriteLine("Sqrt of 9 = " + Sqrt(9));

        string connectionString = "Server=server_name;Database=database_name;User Id=user_id;Password=password;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = new SqlCommand("SELECT FirstName FROM People WHERE PersonId = @PersonId;", connection))
        {
            command.Parameters.AddWithValue("@PersonId", 4);
            connection.Open();

            // using (SqlDataReader reader = command.ExecuteReader())
            using (var reader = command.ExecuteReader())
            {
                string firstName = null;
                if (reader.Read())
                {
                    firstName = reader["FirstName"].ToString();
                }
            }
        }
    }
}
