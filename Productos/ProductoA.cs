using Projecte_programació.Persona.Vendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Producto
{
    internal abstract class ProductoA
    {
        protected Vendedor propietario;
        protected string temporada;
        protected double precioKg;
        protected int cantidad;

        public ProductoA(Vendedor propietario, string temporada, 
            double precioKg, int cantidad)
        {
            this.propietario = propietario;
            this.temporada = temporada;
            this.precioKg = precioKg;
            this.cantidad = cantidad;
        }

        public ProductoA(): this(new Autonomo(),"",0,0) 
        { 
        }

        public Vendedor GetPropietario()
        {
            return propietario;
        }

        public void SetPropietario(Vendedor propietario)
        {
            this.propietario = propietario;
        }

        public string GetTemporada()
        {
            return temporada;
        }

        public void SetTemporada(string temporada)
        {
            this.temporada = temporada;
        }

        public double GetPrecioKg()
        {
            return precioKg;
        }

        public void SetPrecioKg(double precioKg)
        {
            this.precioKg = precioKg;
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
    }
}
