using Projecte_programació.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Persona.Cliente
{
    internal abstract class ClienteC: Persona
    {
        protected int id_Cliente;
        protected List<ProductoA> listaCompra;



        public ClienteC(string nombre, string contrasenya, string localizacion, 
            string correo, int id_Cliente) : 
            base(nombre, contrasenya, localizacion, correo)
        {
            this.id_Cliente = id_Cliente;
            listaCompra = new List<ProductoA>();
        }

        public ClienteC() : 
            this("","","","",0)
        {
        }

        public int GetId_Cliente()
        {
            return id_Cliente;
        }
        public void SetId_Cliente(int id_Cliente)
        {
            this.id_Cliente=id_Cliente;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
