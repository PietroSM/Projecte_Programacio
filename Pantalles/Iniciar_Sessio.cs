using Projecte_programació.Persona;
using Projecte_programació.Persona.Vendedor;
using Projecte_programació.Producto;
using Projecte_programació.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte_programació.Pantalles
{
    public partial class Iniciar_Sessio : Form
    {
        Pagina_Vendedor_Main paginaVendedor;
        Pagina_Client_Main paginaCliente;
        private Usuarios listUsu;
        private Inventario inventario;

        public Iniciar_Sessio(Usuarios usu)
        {
            InitializeComponent();
            listUsu = usu;
            inventario = new Inventario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correoTB, contrasenyaTB;

            correoTB = TBnombre.Text;
            contrasenyaTB = TBcontra.Text;


            if (!string.IsNullOrWhiteSpace(TBnombre.Text)
                && listUsu.ComprovarCredenciales(correoTB,contrasenyaTB))
            {
                if(listUsu.tipoUsuario(correoTB) == "vendedor")
                {
                    inventario.GetLista_Inventario().Clear();
                    inventario.LeerFichero();


                    //lista amb productes de asoles ixe vendedor
                    List<ProductoA> listaEnviar =
                        inventario.GetLista_Inventario().
                        Where(p => p.GetPropietario().GetCorreo() == correoTB)
                        .ToList();


                    //llista amb productes que no tinguen ixe propietari
                    List<ProductoA> listaConservar =
                        inventario.GetLista_Inventario().
                        Where(p => p.GetPropietario().GetCorreo() !=
                        correoTB).ToList();


                    //Netegem el inventari i tornem a guardar asoles
                    //les no enviades
                    inventario.GetLista_Inventario().Clear();
                    inventario.SetLista_Inventario(listaConservar);


                    paginaVendedor = new Pagina_Vendedor_Main(
                        listUsu, listUsu.PosicionLista(correoTB),listaEnviar);
                    //paginaVendedor.Show();
                    DialogResult resultadoPaginaVendedor = paginaVendedor.ShowDialog();

                    //Guardar els productes resultants de la pagina vendedor
                    paginaVendedor.ProductosVendedor
                        .ForEach(p => inventario.AnyadirProducto(p));

                    inventario.GuardarFichero();
                }
                else if(listUsu.tipoUsuario(correoTB) == "cliente")
                {
                    inventario.GetLista_Inventario().Clear();
                    inventario.LeerFichero();

                    paginaCliente = new Pagina_Client_Main(
                        listUsu, listUsu.PosicionLista(correoTB),
                        inventario.GetLista_Inventario());

    


                    DialogResult resultadoPaginaCliente = paginaCliente.ShowDialog();
                    //inventario.GetLista_Inventario().Clear();


                }
            }
            else
            {
                MessageBox.Show("Correo o Contraseña erronea");
            }
        }
    }
}
