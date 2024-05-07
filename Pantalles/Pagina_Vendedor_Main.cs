using Projecte_programació.Persona;
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

        public Pagina_Vendedor_Main(Usuarios usu, int posLista)
        {
            InitializeComponent();
            listUsu = usu;
            this.posLista = posLista;


            Eliminar_Boton_Columna();
        }

        private void Eliminar_Boton_Columna()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "NOMBRE";
            dataGridView1.Columns[1].Name = "TEMPORADA";
            dataGridView1.Columns[2].Name = "PRECIO";
            dataGridView1.Columns[3].Name = "CANTIDAD";

            
        }
    }
}
