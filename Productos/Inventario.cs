using Projecte_programació.Interfaces;
using Projecte_programació.Producto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Productos
{
    public class Inventario : ILeerArchivos
    {
        private List<ProductoA> lista_inventario;

        public Inventario()
        {
            lista_inventario = new List<ProductoA>();
        }

        public void LeerFichero()
        {
            StreamReader miFichero = null;
            string linia = "";
            string nombreFichero = "Inventario.txt";

            try
            {
                miFichero = new StreamReader(nombreFichero);
                linia = miFichero.ReadLine();

                while( linia != null )
                {
                    string[] parts = linia.Split(';');

                    //Toca llegir el fitxer d'usuaris per a comparar els emails
                    //i saber qui es el vendedor;
                }



            }
            catch (IOException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
