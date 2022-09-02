using System;

namespace SalesWeb.Services.Exceptions
{
    public class DbConcurrencyExpection : ApplicationException
    {
        public DbConcurrencyExpection(string message) : base(message)
        {
        }
    }
}
