using System;

public abstract class DbConnection
{
    public string ConnectionString { get; set; }

    public DbConnection(string connectionName)
    {
        if(connectionName == null || connectionName.Length == 0)
        {
            throw new InvalidOperationException("Please enter a database name.");
        }
        else
        {
            this.ConnectionString = connectionName;
        }
    }

    public abstract void OpenDB();

    public abstract void CloseDB();



}
