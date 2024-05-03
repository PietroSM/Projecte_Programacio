using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Persona
{
    internal abstract class Persona
    {
        protected string nombre;
        protected string contrasenya;
        protected string localizacion;
        protected string correo;

        public Persona(string nombre, string contrasenya, string localizacion, 
            string correo)
        {
            this.nombre = nombre;
            this.contrasenya = contrasenya;
            this.localizacion = localizacion;
            this.correo = correo;
        }

        protected Persona():
            this("","","","")
        {
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetContrasenya()
        {
            return contrasenya;
        }

        public void SetContrasenya(string contrasenya)
        {
            this.contrasenya = contrasenya;
        }

        public string GetLocalizacion()
        {
            return localizacion;
        }

        public void SetLocalizacion(string localizacion)
        {
            this.localizacion = localizacion;
        }

        public string GetCorreo()
        {
            return correo;
        }

        public void SetCorreo(string correo)
        {
            this.correo = correo;
        }

        public override string ToString()
        {
            return "{" +
                            "nombre=" + nombre +
                            ", contrasenya=" + contrasenya +
                            ", localizacion=" + localizacion +
                            ", correo=" + correo +
                            '}';
        }
    }
}
