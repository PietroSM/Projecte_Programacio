using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Persona.Cliente
{
    internal class Empresa : Cliente
    {
        private string cif;

        public Empresa(string nombre, string contrasenya, string localizacion, 
            string correo, int id_Cliente, string cif) : 
            base(nombre, contrasenya, localizacion, correo, id_Cliente)
        {
            this.cif = cif;
        }

        public Empresa() :
            this("","","","",0,"")
        {
        }

        public string GetCif()
        {
            return cif;
        }
        public void SetCif(string cif)
        {
            this.cif = cif;
        }
    }
}
