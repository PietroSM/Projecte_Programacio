using Projecte_programació.Interfaces;
using Projecte_programació.Persona.Cliente;
using Projecte_programació.Persona.Vendedor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte_programació.Persona
{
    public class Usuarios : ILeerArchivos
    {
        private List<Persona> personaList;

        public Usuarios()
        {
            personaList = new List<Persona>();
        }



        public List<Persona> GetPersonaList()
        {
            return personaList;
        }

        //Metodo para anyadir una persona a la lista
        public void AnyadirPersona(Persona persona)
        {
            personaList.Add(persona);
        }

        //Metodo para comprovar las credenciales del Login
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

        //Metodo para comprovar si el email ya esta utilizado
        public bool ComprovarEmail(string email)
        {
            bool resultat = false;
            for (int i = 0; i < personaList.Count; i++)
            {
                if (personaList[i].GetCorreo() == email)
                {
                    resultat = true;
                }
            }
            return resultat;
        }

        //Metodo que retorna la poscion de la lista de un usuario
        public int PosicionLista(string texto)
        {
            return personaList.IndexOf(
                    new Cooperativa("", "", "", texto, 0, ""));
        }

        //Metodo para saber el tipo de usuario
        public string tipoUsuario(string texto)
        {
            return personaList[PosicionLista(texto)] is VendedorC ? "vendedor" :
                personaList[PosicionLista(texto)] is ClienteC ? "cliente" : "error";
        }

        //Metodo para leer fichero
        public void LeerFichero()
        {
            StreamReader mifichero = null;
            string linia = "";
            string nombreFichero = "Usuarios.txt";

            try
            {
                mifichero = new StreamReader(nombreFichero);
                linia = mifichero.ReadLine();

                while (linia != null)
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
                    else if (parts[4] == "0")
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

        //Metodo para guardar la lista en el fichero
        public void GuardarFichero()
        {
            StreamWriter miFichero = null;
            string nombrefichero = "Usuarios.txt";

            try
            {
                miFichero = new StreamWriter(nombrefichero);

                for (int i = 0;i<personaList.Count;i++)
                {
                    if (personaList[i] is Particular)
                    {
                        miFichero.WriteLine(personaList[i].GetNombre()+";"+
                            personaList[i].GetContrasenya()+";"+
                            personaList[i].GetLocalizacion()+";"+
                            personaList[i].GetCorreo()+";0;"+
                            ((Particular)personaList[i]).GetDni());
                    }
                    else if (personaList[i] is Empresa)
                    {
                        miFichero.WriteLine(personaList[i].GetNombre() + ";" +
                            personaList[i].GetContrasenya() + ";" +
                            personaList[i].GetLocalizacion() + ";" +
                            personaList[i].GetCorreo() + ";1;" +
                            ((Empresa)personaList[i]).GetCif());
                    }
                    else if (personaList[i] is Autonomo)
                    {
                        miFichero.WriteLine(personaList[i].GetNombre() + ";" +
                            personaList[i].GetContrasenya() + ";" +
                            personaList[i].GetLocalizacion() + ";" +
                            personaList[i].GetCorreo() + ";2;" +
                            ((Autonomo)personaList[i]).GetCIF());
                    }
                    else if (personaList[i] is Cooperativa)
                    {
                        miFichero.WriteLine(personaList[i].GetNombre() + ";" +
                            personaList[i].GetContrasenya() + ";" +
                            personaList[i].GetLocalizacion() + ";" +
                            personaList[i].GetCorreo() + ";3;" +
                            ((Cooperativa)personaList[i]).GetCIF());
                    }
                }
            }
            catch (IOException)
            {

                Console.WriteLine("Error");
            }
            finally
            {
                if (miFichero != null)
                    miFichero.Close();
            }
        }

        //Metodo para devolver una persona
        public Persona BuscadorPersona(string email)
        {
            return personaList[personaList.IndexOf(
                new Cooperativa("", "", "", email, 0, ""))];
        }

        //Metodo para devolver una persona
        public Persona BuscadorPersona2(int pos)
        {
            return personaList[pos];
        }

        //Metodo utilizado para debbugear
        public string MostrarDatos1(int pos)
        {
            return personaList[pos].ToString();
        }
    }
}
