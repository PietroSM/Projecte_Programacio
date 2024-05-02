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
    public partial class Pagina_Benvinguda : Form
    {
        registrarse formuRegistro;

        public Pagina_Benvinguda()
        {
            InitializeComponent();
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            formuRegistro = new registrarse();
            formuRegistro.ShowDialog();
        }
    }
}
