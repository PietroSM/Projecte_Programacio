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
    public partial class Pagina_Benvinguda : Form
    {
        registrarse formuRegistro;
        Iniciar_Sessio formuIniciar;
        private Usuarios listaUsu;

        public Pagina_Benvinguda(Usuarios listaUsu)
        {
            InitializeComponent();
            this.listaUsu = listaUsu;
        }


        private void Registrarse_Click(object sender, EventArgs e)
        {
            formuRegistro = new registrarse(listaUsu);
            formuRegistro.Show();
            this.Hide();
        }


        private void iniciar_sessio_Click(object sender, EventArgs e)
        {
            formuIniciar = new Iniciar_Sessio(listaUsu);
            formuIniciar.Show();
            this.Hide();
        }
    }
}
