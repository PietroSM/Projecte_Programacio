using Projecte_programació.Persona.Cliente;
using Projecte_programació.Persona.Vendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Persona
{
    public class Usuarios
    {
        private List<Persona> personaList;

        public Usuarios()
        {
            personaList = new List<Persona>();
        }


        public void AnyadirPersona(Persona persona)
        {
            personaList.Add(persona);
        }

        public string MostrarDatos1(int pos)
        {
            return personaList[pos].ToString();
        }

        public bool ComprovarCredenciales(string texto, string password)
        {
            bool resultat = false;

            if (personaList.Contains(new Cooperativa("", "", "", texto, 0, "")))
            {
                if (personaList[personaList.IndexOf(
                    new Cooperativa("", "", "", texto, 0, ""))]
                    .GetContrasenya() == password)
                {
                    resultat = true;
                }
            }
            return resultat;
        }

        public int PosicionLista(string texto)
        {
            return personaList.IndexOf(
                    new Cooperativa("", "", "", texto, 0, ""));
        }

        public string tipoUsuario(string texto)
        {
            return personaList[PosicionLista(texto)] is VendedorC ? "vendedor" :
                personaList[PosicionLista(texto)] is ClienteC ? "cliente" : "error";
        }
    }
}
