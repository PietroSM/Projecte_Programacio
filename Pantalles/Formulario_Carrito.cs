using Projecte_programació.Persona;
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
    public partial class Formulario_Carrito : Form
    {
        private Usuarios listUsu;
        private int posLista;
        private List<ProductoA> listaProductosComprar;


        public Formulario_Carrito(Usuarios usu, int posLista,
            List<ProductoA> listaProductosComprar)
        {
            InitializeComponent();
            listUsu = usu;
            this.listaProductosComprar = listaProductosComprar;
            this.posLista = posLista;
            TBprecioTotal.ReadOnly = true;
            TBprecioTotal.Text = Convert.ToString(
                Inventario.CalcularPrecio(listaProductosComprar) + " €");
        }


        public List<ProductoA> ListaProductosComprar
        {
            get { return listaProductosComprar; }
        }

        //Carga la lista en la GridView
        private void Formulario_Carrito_Load(object sender, EventArgs e)
        {
            listaProductosComprar.ForEach(
                p => productoABindingSource.Add(p));
        }
        
        //Vuelve a la pagina anterior
        private void BTNback_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Metodo que controla el click del boton comprar.
        //Muestra un mensaje de compra realizada, limpia la lista y cierra la pagina
        private void BTNcompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Compra realizada, total: {TBprecioTotal.Text}");
            listaProductosComprar.Clear();
            Close();
        }
    }
}
