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



        public void SetLista_Inventario(List<ProductoA> lista_inventario)
        {
            this.lista_inventario = lista_inventario;
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


        public void GuardarFichero()
        {
            StreamWriter miFichero = null;
            string fichero = "Inventario.txt";

            try
            {
                miFichero = new StreamWriter(fichero, false);

                for (int i = 0; i < lista_inventario.Count; i++)
                {
                    if (lista_inventario[i] is Fruta)
                    {
                        miFichero.WriteLine(
                            lista_inventario[i].GetPropietario().GetCorreo()+";"+
                            "0;" + lista_inventario[i].GetTemporada() + ";" +
                            lista_inventario[i].GetPrecioKg()+";"+
                            lista_inventario[i].GetCantidad()+";"+
                            lista_inventario[i].GetNombre());
                    }
                    else if(lista_inventario[i] is Verdura)
                    {
                        miFichero.WriteLine(
                            lista_inventario[i].GetPropietario().GetCorreo() + ";" +
                            "1;" + lista_inventario[i].GetTemporada() + ";" +
                            lista_inventario[i].GetPrecioKg() + ";" +
                            lista_inventario[i].GetCantidad() + ";" +
                            lista_inventario[i].GetNombre());
                    }
                    else if(lista_inventario[i] is Hortaliza)
                    {
                        miFichero.WriteLine(
                            lista_inventario[i].GetPropietario().GetCorreo() + ";" +
                            "1;" + lista_inventario[i].GetTemporada() + ";" +
                            lista_inventario[i].GetPrecioKg() + ";" +
                            lista_inventario[i].GetCantidad() + ";" +
                            lista_inventario[i].GetNombre());
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
