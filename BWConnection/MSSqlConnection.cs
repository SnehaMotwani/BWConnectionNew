using System;
using System.Collections.Generic;
using System.Text;

namespace BWConnection
{
    class MSSqlConnection : BWConnection
    {
        public MSSqlConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Sql connection is open");
        }
        public override void Close()
        {
            Console.WriteLine("Sql connection is closed");
        }

    }
}
