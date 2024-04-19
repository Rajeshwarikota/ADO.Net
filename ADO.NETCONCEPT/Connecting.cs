using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETCONCEPT
{
    public class Connecting
    {
        
            public void Connection()
            {
                // Attempt to establish the database connection within a try-catch-finally block
                try
                {
                    // Using statement ensures proper resource disposal

                    // If we don't use using block to create connection, we have to close connection explicitly. In the following example, we are using try-block instead of using block.
                    using (SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = FILM; Integrated Security = True"))
                    {
                        // Open the database connection
                        con.Open();

                        // Display a message indicating successful connection establishment
                        Console.WriteLine("Connection Established Successfully");
                    } // The using statement automatically disposes of the SqlConnection object
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during connection establishment
                    Console.WriteLine("Oops, something went wrong while establishing the connection: " + ex.Message);
                }
                finally
                {
                    // Code inside the finally block will execute whether an exception occurs or not
                    Console.WriteLine("Cleaning up resources..."); // Example cleanup message

                    // Additional cleanup code can be added here, such as closing additional resources
                }
            }
        public void Command()
        {
            {
                SqlConnection con = null;
                try
                {
                    // Creating Connection
                    con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = FILM; Integrated Security = True");

                    // Writing SQL query
                    SqlCommand cm = new SqlCommand("SELECT * FROM actor", con);

                    // Opening Connection
                    con.Open();

                    // Executing the SQL query
                    SqlDataReader sdr = cm.ExecuteReader();

                    // Reading and displaying actor data
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["name"] + " " + sdr["email"]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oops, something went wrong: " + e);
                }
                finally
                {
                    // Closing the connection
                    con?.Close();
                }
            }
        }

    }
}
