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
    public partial class Pagina_Vendedor_Main : Form
    {
        private Usuarios listUsu;
        private int posLista;
        private Inventario inventario;
        Formulario_Añadir_Productos formuAnyadir;

        public Pagina_Vendedor_Main(Usuarios usu, int posLista)
        {
            InitializeComponent();
            listUsu = usu;
            this.posLista = posLista;
            inventario = new Inventario();
            inventario.LeerFichero();
            formuAnyadir = new Formulario_Añadir_Productos();
     

            Eliminar_Boton_Columna();
        }

        private void Eliminar_Boton_Columna()
        {

            
        }

        private void Pagina_Vendedor_Main_Load(object sender, EventArgs e)
        {
            //productoABindingSource1.Add(inventario.GetLista_Inventario()[0]);
            inventario.GetLista_Inventario().ForEach(
                p => productoABindingSource1.Add(p));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if(MessageBox.Show("Estas Seguro de eliminar este producto?","Message",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productoABindingSource1.RemoveCurrent();
                }
            }

        }

        private void BTNanyadir_Click(object sender, EventArgs e)
        {
            formuAnyadir.Limpiar();
            DialogResult resultadoEditar = formuAnyadir.ShowDialog();

            if (!formuAnyadir.Cancelar)
            {
                if (formuAnyadir.Fruta)
                {
                    inventario.AnyadirProducto(
                        new Fruta((VendedorC)listUsu.BuscadorPersona2(posLista),
                        formuAnyadir.Temporada,
                        formuAnyadir.PrecioKg,
                        formuAnyadir.Cantidad,
                        formuAnyadir.Nombre));
                }
                else if (formuAnyadir.Verdura)
                {
                    inventario.AnyadirProducto(
                        new Verdura((VendedorC)listUsu.BuscadorPersona2(posLista),
                        formuAnyadir.Temporada,
                        formuAnyadir.PrecioKg,
                        formuAnyadir.Cantidad,
                        formuAnyadir.Nombre));
                }
                else if (formuAnyadir.Hortaliza)
                {
                    inventario.AnyadirProducto(
                        new Hortaliza((VendedorC)listUsu.BuscadorPersona2(posLista),
                        formuAnyadir.Temporada,
                        formuAnyadir.PrecioKg,
                        formuAnyadir.Cantidad,
                        formuAnyadir.Nombre));
                }
            }
            dataGridView1.DataSource = typeof(ProductoA);
            dataGridView1.DataSource = inventario.GetLista_Inventario();

        }




    }
}
