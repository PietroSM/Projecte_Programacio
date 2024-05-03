using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Persona.Cliente
{
    internal class Particular : Cliente
    {
        private string dni;



        public Particular(string nombre, string contrasenya, string localizacion, 
            string correo, int id_Cliente, string dni) : 
            base(nombre, contrasenya, localizacion, correo, id_Cliente)
        {
            this.dni = dni;
        }

        public Particular() : 
            this("","","","",0,"")
        {
        }

        public string GetDni()
        {
            return dni;
        }
        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
