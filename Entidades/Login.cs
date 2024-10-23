using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        public Login(int id, string nombre, string password)
        {
            Id = id;
            Nombre = nombre;
            Password = password;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
    }
}
