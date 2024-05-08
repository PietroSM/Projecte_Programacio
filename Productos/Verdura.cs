using Projecte_programació.Persona.Vendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Producto
{
    public class Verdura : ProductoA
    {
        public Verdura(VendedorC propietario, string temporada, double precioKg, 
            int cantidad, string nombre) : 
            base(propietario, temporada, precioKg, cantidad, nombre)
        {
        }

        public Verdura() : this(new Autonomo(), "", 0, 0, "")
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
