using Projecte_programació.Persona.Vendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Producto
{
    internal class Hortaliza : ProductoA
    {
        public Hortaliza(VendedorC propietario, string temporada, 
            double precioKg, int cantidad) : 
            base(propietario, temporada, precioKg, cantidad)
        {
        }

        public Hortaliza() : this(new Autonomo(), "", 0, 0)
        {
        }
    }
}
