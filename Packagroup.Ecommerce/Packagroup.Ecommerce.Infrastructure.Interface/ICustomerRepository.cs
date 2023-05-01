using System;
using System.Collections.Generic;
using System.Text;
using Packagroup.Ecommerce.Domain.Entity;
using System.Threading.Tasks;


namespace Packagroup.Ecommerce.Infrastructure.Interface
{
    public interface ICustomerRepository
    {
        //METODOS DEl OBJETO DE DOMINIO CUSTOMERS

        #region METODO SINCRONOS
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(string CustomerId);
        Customer Get(string CustomerId);
        IEnumerable<Customer> GetAll();
        #endregion


        #region METODO ASINCRONOS
        Task<bool> InsertAsync(Customer customer);
        Task<bool> UpdateAsync(Customer customer);
        Task<bool> DeleteAsync(string CustomerId);
        Task<Customer> GetAsync(string CustomerId);
        Task<IEnumerable<Customer>> GetAllAsync();
        #endregion


    }
}
