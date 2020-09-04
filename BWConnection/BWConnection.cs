using System;
using System.Collections.Generic;
using System.Text;

namespace BWConnection
{
    public abstract class BWConnection
    {
        private string connectionString;
        public TimeSpan timeOut;

        protected BWConnection(string aConnectionString, TimeSpan aTimeOut)
        {
            ConnectionString = aConnectionString;
            timeOut = aTimeOut;
        }
        protected string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Connection String is null or empty");
                }else
                {
                    connectionString = value;
                }
            }
        }
        public abstract void Open();

        public abstract void Close();
    }
}
