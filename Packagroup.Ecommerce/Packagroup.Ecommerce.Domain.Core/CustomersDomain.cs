using System;
using Packagroup.Ecommerce.Domain.Entity;
using Packagroup.Ecommerce.Domain.Interface;
using Packagroup.Ecommerce.Infrastructure.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Packagroup.Ecommerce.Domain.Core
{
    public class CustomersDomain : ICustomersDomain
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersDomain(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        #region Metodos Sincronos


        public bool Insert(Customers customer)
        {
            return _customerRepository.Insert(customer);
        }

        public bool Update(Customers customer)
        {
            return _customerRepository.Update(customer);
        }


        public bool Delete(string CustomerId)
        {
            return _customerRepository.Delete(CustomerId);
        }
        public Customers Get(string CustomerId)
        {
            return _customerRepository.Get(CustomerId);
        }

        public IEnumerable<Customers> GetAll()
        {
            return _customerRepository.GetAll();
        }
        #endregion

        #region Metodos Asincronos


        public async Task<bool> InsertAsync(Customers customer)
        {
            return await _customerRepository.InsertAsync(customer);
        }

        public async Task<bool> UpdateAsync(Customers customer)
        {
            return await _customerRepository.InsertAsync(customer);
        }


        public async Task<bool> DeleteAsync(string CustomerId)
        {
            return await _customerRepository.DeleteAsync(CustomerId);
        }
        public async Task<Customers> GetAsync(string CustomerId)
        {
            return await _customerRepository.GetAsync(CustomerId);
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }
        #endregion
    }
}
