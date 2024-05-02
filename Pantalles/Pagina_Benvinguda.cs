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
        Iniciar_Sessio formuIniciar;

        public Pagina_Benvinguda()
        {
            InitializeComponent();
        }


        private void Registrarse_Click(object sender, EventArgs e)
        {
            formuRegistro = new registrarse();
            formuRegistro.ShowDialog();
        }

        private void Pagina_Benvinguda_Load(object sender, EventArgs e)
        {

        }

        private void iniciar_sessio_Click(object sender, EventArgs e)
        {
            formuIniciar = new Iniciar_Sessio();
            formuIniciar.ShowDialog();
        }
    }
}
