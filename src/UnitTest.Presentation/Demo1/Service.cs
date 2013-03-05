using System.Collections.Generic;
using System;

namespace UnitTest.Presentation.Demo1
{
    //todo: refactor to use abstraction instead of implementation
    public class Service
    {
        private readonly CustomerRepository _repository;

        public Service(CustomerRepository repository)
        {
            _repository = repository;
        }

        public bool CustomerExistById(int id)
        {
            return _repository.GetCustomerById(id) != null;
        }
    }
}