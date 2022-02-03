using System;

namespace DatabaseConnection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a database and type its name as shown below.");
            Console.WriteLine("SQL");
            Console.WriteLine("ORACLE");
            Console.Write("Selected Database: ");
            string databaseSelection = Console.ReadLine();
            string instruction = "Select * from USER;";


            switch (databaseSelection.ToLower())
            {
                case "sql":
                    SqlConnection sqlConnection = new SqlConnection("SQL");
                    DbCommand dbCommandSql = new DbCommand(sqlConnection,instruction);
                    dbCommandSql.Execute();
                    
                    break;

                case "oracle":
                    OracleConnection oracleConnection = new OracleConnection("Oracle");
                    DbCommand dbCommandOracle = new DbCommand(oracleConnection, instruction);
                    dbCommandOracle.Execute();
                    
                    break;

                default:
                    throw new InvalidOperationException("Select valid Database!");
            }
            

        }

        
        

    }

}
