using App.Core.Models;
using System;
using System.Text;
using System.Collections.Generic;


namespace App.Core.Contracts
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(string id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(string id);
        List<Customer> Search(string query);

    }
}
