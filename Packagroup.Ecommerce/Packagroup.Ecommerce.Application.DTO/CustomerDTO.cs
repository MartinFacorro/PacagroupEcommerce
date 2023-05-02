using System;

namespace Packagroup.Ecommerce.Application.DTO
{
    public class CustomerDTO
    {
        // UN CASO DE USO ES CUANDO UTILIZAMOS UNA ENTIDAD DE NEGOCIO CON 50 CAMPOS, PERO SOLO QUEREMOS DEVOLVER 10 CAMPOS. PARA ELLO USAMOS DTO. 


        public string Customerld { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTit1e { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

    }
}
