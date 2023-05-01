using System;
using Packagroup.Ecommerce.Domain.Entity;
using Packagroup.Ecommerce.Infrastructure.Interface;
using Packagroup.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Packagroup.Ecommerce.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly IConnectionFactory _connectionFactory;

        public CustomerRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Metodos Sincronos
        public bool Insert(Customer customer)
        {
            using (var connection = _connectionFactory)
            {
                var query = "CustomersInsert";

                var parameters = new DynamicParameters();

                parameters.add("Customerld", customer.Customerld);
                parameters.add("CompanyName ", customer.CompanyName);
                parameters.add("ContactName", customer.ContactName);
                parameters.add("ContactTit1e", customer.ContactTit1e);
                parameters.add("Address", customer.Address);
                parameters.add("City", customer.City);
                parameters.add("Region", customer.Region);
                parameters.add("PostalCode", customer.PostalCode);
                parameters.add("Country", customer.Country);
                parameters.add("Phone", customer.Phone);
                parameters.add("Fax ", customer.Fax);
            }
        }

        bool Update(Customer customer);
        bool Delete(string CustomerId);
        Customer Get(string CustomerId);
        IEnumerable<Customer> GetAll();
        #endregion


    }
}
