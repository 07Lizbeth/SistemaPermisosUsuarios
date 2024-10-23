using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoLogin
    {
        public static string user;
        ConectarBD b = new ConectarBD("localhost", "root", "", "sistema");

        public bool Validar(string nombre, string password)
        {
            return b.Dato(string.Format("call validarusuario('{0}','{1}');", nombre, password));
        }
        public string Informacion(string columna, string tabla, string where, string parametro)
        {
            string query = string.Format("SELECT {0} FROM {1} WHERE {2} = @parametro", columna, tabla, where);

            var parameters = new Dictionary<string, object>
            {
                {"@parametro", parametro}
            };

            return b.Dato2(query, parameters);
        }
        public bool Permisos(string columna, string parametro1, string parametro2)
        {
            string query = string.Format("SELECT {0} FROM permisos " +
                "WHERE fkusuario = @parametro1 AND formulario = @parametro2",
                columna,parametro1,parametro2);

            var parameters = new Dictionary<string, object>
            {
                {"@parametro1", parametro1},
                {"@parametro2", parametro2},
            };

            return b.Dato3(query, parameters);
        }
    }
}
