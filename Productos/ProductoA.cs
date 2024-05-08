using Projecte_programació.Persona.Vendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Producto
{
    public abstract class ProductoA
    {
        protected VendedorC propietario;
        protected string temporada;
        protected double precioKg;
        protected int cantidad;
        protected string nombre;

        public VendedorC Propietario { get => propietario; set => propietario = value; }
        public string Temporada { get => temporada; set => temporada = value; }
        public double PrecioKg { get => precioKg; set => precioKg = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public ProductoA(VendedorC propietario, string temporada, 
            double precioKg, int cantidad, string nombre)
        {
            this.propietario = propietario;
            this.temporada = temporada;
            this.precioKg = precioKg;
            this.cantidad = cantidad;
            this.nombre = nombre;
        }

        public ProductoA(): this(new Autonomo(),"",0,0,"") 
        { 
        }

        public VendedorC GetPropietario()
        {
            return propietario;
        }

        public void SetPropietario(VendedorC propietario)
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

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
