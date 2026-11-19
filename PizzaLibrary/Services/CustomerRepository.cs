using PizzaLibrary.Interfaces;
using PizzaLibrary.Data;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Dictionary<string, ICustomer> _customers;
        public CustomerRepository()
        {
            _customers = MockData.CustomerData;
        }

        public int Count => _customers.Count;

        public void AddCustomer(ICustomer customer)
        {
            _customers.Add(customer.Mobile, customer);
        }

        public List<ICustomer> GetAll()
        {
            List<ICustomer> returList1 = new List<ICustomer>();

            foreach(ICustomer customer in _customers.Values)
            {
                returList1.Add(customer);
            }
            return returList1;

        }

        public ICustomer GetCustomerByMobile(string mobile)
        {
            if (_customers.ContainsKey(mobile)) return _customers[mobile];
            
            return null;
        }

        public void PrintAllCustomers()
        {
            foreach (ICustomer ic in _customers.Values)
            {
                Console.WriteLine(ic.ToString());
            }
            
        }

        public void RemoveCustomer(string mobile)
        {
            _customers.Remove(mobile);
        }

        public List<ICustomer> GetAllClubmembers()
        {
            List<ICustomer> clubmembers = new List<ICustomer>();

            foreach(ICustomer customer in _customers.Values)
            {
                if (customer.ClubMember == true)
                {
                    clubmembers.Add(customer);
                }
            }
            return clubmembers;
        }

        public List<ICustomer> CustomerFromRoskilde()
        {
            List<ICustomer> fromRoskilde = new List<ICustomer>();

            foreach(ICustomer customer in _customers.Values)
            {
                if (customer.City == "Roskilde")
                {
                    fromRoskilde.Add(customer);
                }
            }
            return fromRoskilde;
        }
    }
}
