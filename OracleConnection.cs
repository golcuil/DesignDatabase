using System;

class OracleConnection : DbConnection
{
    public OracleConnection(string connectionName)
        : base(connectionName)
    {
        
    }

    public override void OpenDB()
    {

        Console.WriteLine("Welcome to Oracle Database");

    }

    public override void CloseDB()
    {
        Console.WriteLine("Thanks for using Oracle Database...");
    }
}
