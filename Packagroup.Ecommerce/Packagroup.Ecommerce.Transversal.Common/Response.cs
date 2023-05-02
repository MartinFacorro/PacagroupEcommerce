using System;
using System.Collections.Generic;
using System.Text;

namespace Packagroup.Ecommerce.Transversal.Common
{
    public class Response<T> // LA ENTIDAD CONTENDRA TODA LA INFORMACION QUE VAN A EXPONER LOS RECURSOS DE NUESTRA WEB APO
    {
        public T Data { get; set; } //CONTENDRA LA INFORMACION DE LOS METODOS DE LA CAPA DE DOMINIO
        public bool IsSuccess { get; set; } // INFORMACION DEL ESTADO DE EJECUCION
        public string Message { get; set; } //MENSAJE DE OPERACION, PARA CASOS DE EXITOS O EXCEPTIONS.
    }
}
