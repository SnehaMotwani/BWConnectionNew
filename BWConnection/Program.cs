using System;

namespace BWConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Sql connection is open
               Sql connection is closed
               Oracle Connection is open
               Oracle Connection is closed
               Connection String is null or empty
             */
            MSSqlConnection sqlConnection = new MSSqlConnection("Some Connection String for sql connection", TimeSpan.FromSeconds(30));
            sqlConnection.Open();
            sqlConnection.Close();

            OracleDBConnection oracleDB1 = new OracleDBConnection("Connection String for Oracle ", TimeSpan.FromSeconds(30));
            oracleDB1.Open();
            oracleDB1.Close();

            OracleDBConnection oracleDB2 = new OracleDBConnection("", TimeSpan.FromSeconds(45));    //null or empty case
            //oracleDB2.Open();

            Console.ReadLine();
        }
    }
}
