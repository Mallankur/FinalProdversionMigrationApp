using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Program
    {
        static void Main(string[] args)
        {
            // Cycle 3413,705,2556,2694
            


            string sqlConnectionString = "server=AVINEXSERVER6;database=CatCheckPro;Integrated Security=false;User ID=CCAdmin;Password=Catalyst1*;Trusted_Connection=No;";


            string storeProcedureName = "uspGetCycleRDEIDs";
            var res = SPReturnData.ReturnSPRdied(sqlConnectionString,  2562,storeProcedureName);
           
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
