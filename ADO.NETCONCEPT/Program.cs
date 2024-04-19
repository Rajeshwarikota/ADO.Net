using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETCONCEPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...ADO NET....");
            Connecting con = new Connecting();
            ////con.Connection();
            con.Command();
            con.DataReader();

            DataManager data = new DataManager();
            data.CreateTable();
            Console.ReadLine();
        }
    }
}
