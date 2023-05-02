using System;
using System.Collections.Generic;
using System.Text;

using Packagroup.Ecommerce.Application.DTO;
using Packagroup.Ecommerce.Transversal.Common;
using System.Threading.Tasks;

namespace Packagroup.Ecommerce.Application.Interface
{
    public interface ICustomerApplication
    {
        #region METODO SINCRONOS
        Response<bool> Insert(CustomerDTO customerDTO);
        Response<bool> Update(CustomerDTO customer);
        Response<bool> Delete(string CustomerId);
        Response<CustomerDTO> Get(string CustomerId);
        Response<IEnumerable<CustomerDTO>> GetAll();
        #endregion


        #region METODO ASINCRONOS
        Task<Response<bool>> InsertAsync(CustomerDTO customer);
        Task<Response<bool>> UpdateAsync(CustomerDTO customer);
        Task<Response<bool>> DeleteAsync(string CustomerId);
        Task<Response<CustomerDTO>> GetAsync(string CustomerId);
        Task<Response<IEnumerable<CustomerDTO>>> GetAllAsync();
        #endregion


    }
}
