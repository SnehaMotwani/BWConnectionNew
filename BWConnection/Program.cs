using System;

namespace BWConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            MSSqlConnection sqlConnection = new MSSqlConnection("Server=myServerName\\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword", TimeSpan.FromSeconds(30));
            sqlConnection.Open();
            sqlConnection.Close();

            OracleDBConnection oracleDB1 = new OracleDBConnection("Server=myServerName\\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword", TimeSpan.FromSeconds(30));
            oracleDB1.Open();
            oracleDB1.Close();

            OracleDBConnection oracleDB2 = new OracleDBConnection("", TimeSpan.FromSeconds(45));
            oracleDB2.Open();

            Console.ReadLine();
        }
    }
}
