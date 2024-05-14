using Projecte_programació.Persona;
using Projecte_programació.Producto;
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
    public partial class Pagina_Client_Main : Form
    {
        Formulario_Carrito formuCarrito;
        private Usuarios listUsu;
        private int posLista;
        private List<ProductoA> listaProductos;


        public Pagina_Client_Main(Usuarios usu, int posLista,
            List<ProductoA> listaProductos)
        {
            InitializeComponent();
            listUsu = usu;
            this.posLista = posLista;
            this.listaProductos = listaProductos;
        }


        public List<ProductoA> ListaProductos
        {
            get { return listaProductos; }
        }

        private void Pagina_Client_Main_Load(object sender, EventArgs e)
        {
            listaProductos.ForEach(
                p => productoABindingSource.Add(p));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNcarrito_Click(object sender, EventArgs e)
        {
            List<ProductoA> listaEnviar = listaProductos.Where(p => p.Comprar == true).ToList();

            formuCarrito = new Formulario_Carrito(listUsu, posLista,
                listaEnviar);

            DialogResult = formuCarrito.ShowDialog();
        }
    }
}
