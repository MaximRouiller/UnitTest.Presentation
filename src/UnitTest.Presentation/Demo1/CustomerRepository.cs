using System.Collections.Generic;
using System;

namespace UnitTest.Presentation.Demo1
{
    public class CustomerRepository
    {
        private readonly string _connectionString;

        public CustomerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public object GetCustomerById(int id)
        {
            return new object();
        }
    }
}