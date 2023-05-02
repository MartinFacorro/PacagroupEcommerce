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
        public bool Insert(Customers customer)
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

        public bool Update(Customers customer)
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


        public Customers Get(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetByID";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", CustomerId);

                var customer = connection.QuerySingle<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;


            }
        }


        public Customers GetAll(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetByID";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", CustomerId);

                var customer = connection.QuerySingle<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;


            }
        }

        public IEnumerable<Customers> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerList";

                var customers = connection.Query<Customers>(query, commandType: CommandType.StoredProcedure);

                return customers;
            }
        }

        #endregion



        #region Metodos Asincronos

        public async Task<bool> InsertAsync(Customers customer)
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

        public async Task<bool> UpdateAsync(Customers customer)
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

        public async Task<Customers> GetAsync(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetByID";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", CustomerId);

                var customer = await connection.QuerySingleAsync<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;


            }
        }



        public async Task<Customers> GetAllAsync(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerGetByID";

                var parameters = new DynamicParameters();

                parameters.Add("Customerld", CustomerId);

                var customer = await connection.QuerySingleAsync<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;


            }
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomerList";

                var customers = await connection.QueryAsync<Customers>(query, commandType: CommandType.StoredProcedure);

                return customers;
            }
        }


        #endregion Metodos Asincronos



    }
}
