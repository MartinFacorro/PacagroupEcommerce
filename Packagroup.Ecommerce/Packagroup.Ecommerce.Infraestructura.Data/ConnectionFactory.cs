using System;
using Packagroup.Ecommerce.Transversal.Common;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Packagroup.Ecommerce.Infraestructura.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        //RESPONSABILIDAD: CONECTARSE A LA BASE DE DATOS Y DEVOLVER LA INSTANCIA DE LA CONEXION.

        private readonly IConfiguration _configuration; // NOS PERMITE ACCEDER A LAS PROPIEDADES DE LOS DIFERENTES PROYECTOS(APPSETINGS.JSON)

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection // CON ESTE METODO ACCEDEMOS A LA BASE DE DATOS Y NOS DEVUELVE UNA INSTANCIA DE CONEXION ABIERTA
        {
            get
            {
                var sqlConnection = new SqlConnection();

                if (sqlConnection == null) 
                    return null;

                sqlConnection.ConnectionString = _configuration.GetConnectionString("NorthwingConnection");
                sqlConnection.Open();

                return sqlConnection;

            }
        }

    }
}
