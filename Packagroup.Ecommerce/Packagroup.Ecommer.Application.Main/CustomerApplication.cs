using System;
using AutoMapper;
using Packagroup.Ecommerce.Application.DTO;
using Packagroup.Ecommerce.Application.Interface;
using Packagroup.Ecommerce.Domain.Entity;
using Packagroup.Ecommerce.Domain.Interface;
using Packagroup.Ecommerce.Transversal.Common;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Packagroup.Ecommerce.Application.Main
{
    public class CustomerApplication : ICustomerApplication
    {
        private readonly ICustomersDomain _customerDomain;
        private readonly IMapper _mapper;

        public CustomerApplication(ICustomersDomain customerDomain, IMapper mapper)
        {
            _customerDomain = customerDomain;
            _mapper = mapper;
        }

        #region METODO SINCRONOS
        public Response<bool> Insert(CustomerDTO customerDTO)
        { 
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDTO);
                response.Data = _customerDomain.Insert(customer);

                if (response.Data) 
                {
                    response.IsSuccess = true;
                    response.Message = "Registros exitoso!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response<bool> Update(CustomerDTO customerDTO) 
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDTO);
                response.Data = _customerDomain.Update(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacion exitosa!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response<bool> Delete(string CustomerId)
        {
            var response = new Response<bool>();
            try
            {
                
                response.Data = _customerDomain.Delete(CustomerId);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "borrado exitoso!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response<CustomerDTO> Get(string CustomerId)
        {
            
                var response = new Response<CustomerDTO>();
                try
                {
                    var customer = _customerDomain.Get(CustomerId);
                    response.Data = _mapper.Map<CustomerDTO>(customer);

                    if (response.Data!=null)
                    {
                        response.IsSuccess = true;
                        response.Message = "Consulta exitosa!";
                    }
                }
                catch (Exception ex)
                {
                    response.Message = ex.Message;
                }

                return response;
            
        }

        public Response<IEnumerable<CustomerDTO>> GetAll()
        {

            var response = new Response<IEnumerable<CustomerDTO>>();
            try
            {
                var customer = _customerDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CustomerDTO>>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        #endregion


        #region METODO ASINCRONOS
        public async Task<Response<bool>> InsertAsync(CustomerDTO customerDTO)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDTO);
                response.Data = await _customerDomain.InsertAsync(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registros exitoso!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public async Task<Response<bool>> UpdateAsync(CustomerDTO customerDTO)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDTO);
                response.Data = await _customerDomain.UpdateAsync(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacion exitosa!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
            public async Task<Response<bool>> DeleteAsync(string CustomerId)
        {
            var response = new Response<bool>();
            try
            {

                response.Data = await _customerDomain.DeleteAsync(CustomerId);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "borrado exitoso!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public async Task<Response<CustomerDTO>> GetAsync(string CustomerId)
        {

            var response = new Response<CustomerDTO>();
            try
            {
                var customer = await _customerDomain.GetAsync(CustomerId);
                response.Data = _mapper.Map<CustomerDTO>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;

        }
        public async Task<Response<IEnumerable<CustomerDTO>>> GetAllAsync()
        {

            var response = new Response<IEnumerable<CustomerDTO>>();
            try
            {
                var customer = await _customerDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CustomerDTO>>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa!";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        #endregion




    }
}
