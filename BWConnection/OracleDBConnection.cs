using System;
using System.Collections.Generic;
using System.Text;

namespace BWConnection
{
    class OracleDBConnection : BWConnection
    {
        public OracleDBConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Oracle Connection is open");
        }
        public override void Close()
        {
            Console.WriteLine("Oracle Connection is closed");
        }
    }
}
