using Projecte_programació.Persona;
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

        public Pagina_Vendedor_Main(Usuarios usu, int posLista)
        {
            InitializeComponent();
            listUsu = usu;
            this.posLista = posLista;
        }


    }
}
