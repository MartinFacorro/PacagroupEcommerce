using System;
using AutoMapper;
using Packagroup.Ecommerce.Application.DTO;
using Packagroup.Ecommerce.Domain.Entity;

namespace Packagroup.Ecommerce.Transversal.Mapper
{
    public class MappingsProfile :Profile
    {
        public MappingsProfile() 
        {
            CreateMap<Customers, CustomerDTO>().ReverseMap(); // EL MAPEO SE REALIZA EN UN SENTIDO Y OTRO YA QUE AMBOS OBJETOS SON IGUALES.


            // VER MAPEO MANUAL 16. Construcción de la Capa de Aplicación MIN 8:50

        }

    }
}
