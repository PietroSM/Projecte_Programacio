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
            get => listaProductos;
            set => listaProductos = value;
        }



        //Carga la lista en la GridView
        private void Pagina_Client_Main_Load(object sender, EventArgs e)
        {
            listaProductos.ForEach(
                p => productoABindingSource.Add(p));
        }

        //metodo que controla el click del bonton carrito
        //Nos redigire a la pagina del carrito, enviando los productos seleccionados
        private void BTNcarrito_Click(object sender, EventArgs e)
        {
            //Productos a enviar
            List<ProductoA> listaEnviar = listaProductos
                .Where(p => p.Comprar == true).ToList();
            //Productos restantes
            List<ProductoA> listaConservar = listaProductos
                .Where(p => p.Comprar == false).ToList();

            formuCarrito = new Formulario_Carrito(listUsu, posLista,
                listaEnviar);
            DialogResult resultadoCompra = formuCarrito.ShowDialog();

            //Volvemos a volcar, los productos que convervamos
            listaProductos.Clear();
            listaConservar.ForEach(p =>  listaProductos.Add(p));

            //Recibimos la lista del carrito por si el ususario al final no compra
            // y lo volvemos a volcar a la lista
            List<ProductoA> listaRecibida = formuCarrito.ListaProductosComprar;
            listaRecibida.ForEach(p => listaProductos.Add(p));

            //Actualizamos el Grid
            dataGridView1.DataSource = typeof(ProductoA);
            dataGridView1.DataSource = listaProductos;
        }

        //Vuelve a la pagina anterior
        private void BTNback_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
