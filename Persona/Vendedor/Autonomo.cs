using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Persona.Vendedor
{
    internal class Autonomo : Vendedor
    {

        public Autonomo(string nombre, string contrasenya, string localizacion, 
            string correo, int id_vendedor, string CIF) : 
            base(nombre, contrasenya, localizacion, correo, id_vendedor, CIF)
        {
        }

        public Autonomo() :
            this("", "", "", "", 0, "")
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
