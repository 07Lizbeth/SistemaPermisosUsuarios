using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public Usuarios(int id, string usuario, string password)
        {
            Id = id;
            Usuario = usuario;
            Password = password;
        }

        public int Id { get; set; }
        public string Usuario { get; set; }    
        public string Password { get; set; }
    }
}
