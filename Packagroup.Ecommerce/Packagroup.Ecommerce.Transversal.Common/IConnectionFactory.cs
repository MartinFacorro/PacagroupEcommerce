using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Packagroup.Ecommerce.Transversal.Common
{
    public interface IConnectionFactory
    {
        // SE CREA UN METODO PARA INTERACTUAR CON EL GESTOR DE BASE DE DATOS
        IDbConnection GetConnection { get; }
    }
}
