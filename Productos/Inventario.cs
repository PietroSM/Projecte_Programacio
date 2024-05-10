using Projecte_programació.Interfaces;
using Projecte_programació.Persona;
using Projecte_programació.Persona.Vendedor;
using Projecte_programació.Producto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte_programació.Productos
{
    public class Inventario : ILeerArchivos
    {
        private List<ProductoA> lista_inventario;

        public Inventario()
        {
            lista_inventario = new List<ProductoA>();
        }

        public List<ProductoA> GetLista_Inventario()
        {
            return lista_inventario;
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

                    Usuarios u1 = new Usuarios();
                    u1.LeerFichero();

                    //Fruta
                    if (parts[1] == "0")
                    {
                        lista_inventario.Add(new Fruta(
                            (VendedorC) u1.BuscadorPersona(parts[0]),
                            parts[2], Convert.ToDouble(parts[3]),
                            Convert.ToInt32(parts[4]), parts[5]));
                    }
                    //Verdura
                    else if (parts[1] == "1")
                    {
                        lista_inventario.Add(new Verdura(
                            (VendedorC)u1.BuscadorPersona(parts[0]),
                            parts[2], Convert.ToDouble(parts[3]),
                            Convert.ToInt32(parts[4]), parts[5]));
                    }
                    //Hortaliza
                    else if(parts[1] == "2")
                    {
                        lista_inventario.Add(new Hortaliza(
                            (VendedorC)u1.BuscadorPersona(parts[0]),
                            parts[2], Convert.ToDouble(parts[3]),
                            Convert.ToInt32(parts[4]), parts[5]));
                    }
                    linia = miFichero.ReadLine();
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                if(miFichero != null) 
                    miFichero.Close();
            }
        }


        public void AnyadirProducto(ProductoA p)
        {
            lista_inventario.Add(p);
        }

        public string MostrarUno(int pos)
        {
            return lista_inventario[pos].ToString();
        }

    }
}
