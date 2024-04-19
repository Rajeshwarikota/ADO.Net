using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETCONCEPT
{
    public class DataManager
    {
        private SqlConnection con;
        public DataManager()
        {
            con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = FILM; Integrated Security = True");
        }
        public void CreateTable()
        {

            try
            {
                // Define SQL query to create a table
                SqlCommand cmd = new SqlCommand("CREATE TABLE Actor (id int not null, name varchar(100), email varchar(50), join_date date)", con);

                // Open the database connection
                con.Open();

                // Execute the SQL query to create the table
                cmd.ExecuteNonQuery();

                // Display a message indicating successful table creation
                Console.WriteLine("Table created successfully");
            }
            catch (Exception e)
            {
                // Handle any exceptions that occur during table creation
                Console.WriteLine("Oops, something went wrong: " + e.Message);
            }
            finally
            {
                // Close the database connection in the finally block
                con?.Close(); // Use null-conditional operator to ensure con is not null before attempting to close
            }
        }

    }
}
