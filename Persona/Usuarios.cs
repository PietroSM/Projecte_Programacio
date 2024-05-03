using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Persona
{
    internal class Usuarios
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
    }
}
