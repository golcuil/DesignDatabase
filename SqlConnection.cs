using System;
using System.Threading;
class SqlConnection : DbConnection
{
    

    public SqlConnection(string connectionName )
        : base(connectionName)
    {
        
    }


    public override void OpenDB()
    {

        Console.WriteLine("Welcome to SQL Database!");

    }

    public override void CloseDB()
    {
        Console.WriteLine("Thanks for using SQL Database!");
    }
}
