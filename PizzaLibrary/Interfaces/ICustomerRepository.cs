using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary.Interfaces
{
    public interface ICustomerRepository
    {
        public int Count { get; }
        List<ICustomer> GetAll();
        void AddCustomer(ICustomer customer);
        List<ICustomer> GetAllClubmembers();
        List<ICustomer> CustomerFromRoskilde();
        ICustomer GetCustomerByMobile(string mobile);
        void RemoveCustomer(string mobile);
        void PrintAllCustomers();

    }

}
