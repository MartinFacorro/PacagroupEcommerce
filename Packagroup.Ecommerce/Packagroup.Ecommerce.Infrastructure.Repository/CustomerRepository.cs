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
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersInsert";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", customer.Customerld);
                parameters.Add("CompanyName ", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTit1e", customer.ContactTit1e);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax ", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;


            }
        }

        public bool Update(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersUpdate";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", customer.Customerld);
                parameters.Add("CompanyName ", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTit1e", customer.ContactTit1e);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax ", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;


            }
        }



        public bool Delete(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersDelete";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", CustomerId);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;

            }
        }

        public Customer GetAll(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetByID";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", CustomerId);

                var customer = connection.QuerySingle<Customer>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;


            }
        }

        public IEnumerable<Customer> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerList";

                var customers = connection.Query<Customer>(query, commandType: CommandType.StoredProcedure);

                return customers;
            }
        }

        #endregion



        #region Metodos Asincronos

        public async Task<bool> InsertAsync(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersInsert";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", customer.Customerld);
                parameters.Add("CompanyName ", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTit1e", customer.ContactTit1e);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax ", customer.Fax);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;


            }
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersUpdate";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", customer.Customerld);
                parameters.Add("CompanyName ", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTit1e", customer.ContactTit1e);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax ", customer.Fax);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;


            }
        }



        public async Task<bool> DeleteAsync(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersDelete";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", CustomerId);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;

            }
        }

        public Task<Customer> GetAsync(string CustomerId)
        { 
        
        }



        public async Task<Customer> GetAllAsync(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetByID";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", CustomerId);

                var customer = await connection.QuerySingleAsync<Customer>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;


            }
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerList";

                var customers = await connection.QueryAsync<Customer>(query, commandType: CommandType.StoredProcedure);

                return customers;
            }
        }


        #endregion Metodos Asincronos



    }
}
