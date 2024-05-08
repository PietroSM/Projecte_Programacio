using Projecte_programació.Interfaces;
using Projecte_programació.Persona.Cliente;
using Projecte_programació.Persona.Vendedor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Persona
{
    public class Usuarios : ILeerArchivos
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

        public List<Persona> GetPersonaList()
        {
            return personaList;
        }

        public void LeerFichero()
        {
            StreamReader mifichero = null;
            string linia = "";
            string nombreFichero = "Usuarios.txt";

            try
            {
                mifichero = new StreamReader(nombreFichero);
                linia = mifichero.ReadLine();

                while(linia != null )
                {
                    string[] parts = linia.Split(';');
                    //Cooperativa
                    if (parts[4] == "3")
                    {
                        personaList.Add(new Cooperativa(parts[0],
                            parts[1], parts[2], parts[3], 
                            Convert.ToInt32(parts[4]), parts[5]));
                    }
                    //Autonomo
                    else if (parts[4] == "2")
                    {
                        personaList.Add(new Autonomo(parts[0],
                            parts[1], parts[2], parts[3],
                            Convert.ToInt32(parts[4]), parts[5]));
                    }
                    //Particular
                    else if(parts[4] == "0")
                    {
                        personaList.Add(new Particular(parts[0],
                            parts[1], parts[2], parts[3],
                            Convert.ToInt32(parts[4]), parts[5]));
                    }
                    //Empresa
                    else if (parts[4] == "1")
                    {
                        personaList.Add(new Empresa(parts[0],
                            parts[1], parts[2], parts[3],
                            Convert.ToInt32(parts[4]), parts[5]));
                    }
                    linia = mifichero.ReadLine();
                }

            }
            catch (IOException)
            {

                Console.WriteLine("Error");
            }
            finally
            {
                if (mifichero != null)
                    mifichero.Close();
            }

        }


        //Devolver Usuario
        public Persona BuscadorPersona(string email)
        {
            return personaList[personaList.IndexOf(
                new Cooperativa("", "", "", email, 0, ""))];
        }
    }
}
