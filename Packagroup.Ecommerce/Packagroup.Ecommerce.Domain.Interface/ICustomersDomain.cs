using System;
using System.Collections.Generic;
using System.Text;
using Packagroup.Ecommerce.Domain.Entity;
using System.Threading.Tasks;

namespace Packagroup.Ecommerce.Domain.Interface
{
    public interface ICustomersDomain
    {

        //METODOS DEl OBJETO DE DOMINIO CUSTOMERS

        #region METODO SINCRONOS
        bool Insert(Customers customer);
        bool Update(Customers customer);
        bool Delete(string CustomerId);
        Customers Get(string CustomerId);
        IEnumerable<Customers> GetAll();
        #endregion


        #region METODO ASINCRONOS
        Task<bool> InsertAsync(Customers customer);
        Task<bool> UpdateAsync(Customers customer);
        Task<bool> DeleteAsync(string CustomerId);
        Task<Customers> GetAsync(string CustomerId);
        Task<IEnumerable<Customers>> GetAllAsync();
        #endregion


    }
}
