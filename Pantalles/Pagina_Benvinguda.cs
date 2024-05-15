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

        public Pagina_Benvinguda()
        {
            InitializeComponent();
            listaUsu = new Usuarios();
        }


        //Metodo que controla el evento del boton registrasre
        //Carga en la lista de ususarios, los objetos del fitchero.
        //Redirige a la pagina de registarse
        //Al volver, guarda los ususarios de nuevo en el fichero
        private void Registrarse_Click(object sender, EventArgs e)
        {
            listaUsu.GetPersonaList().Clear();
            listaUsu.LeerFichero();

            formuRegistro = new registrarse(listaUsu);
            Hide();
            DialogResult resultadoRegistrar = formuRegistro.ShowDialog();
            Show();

            listaUsu = formuRegistro.ListaUsu;
            listaUsu.GuardarFichero();
        }

        //Metodo que controla el evento del boton iniciar sesion
        //Carga en la lista de ususarios, los objetos del fitchero.
        //Redirige a la pagina de iniciar sesion
        //Al volver, guarda los ususarios de nuevo en el fichero
        private void iniciar_sessio_Click(object sender, EventArgs e)
        {
            listaUsu.GetPersonaList().Clear();
            listaUsu.LeerFichero();

            formuIniciar = new Iniciar_Sessio(listaUsu);
            Hide();
            DialogResult resultadoInciar = formuIniciar.ShowDialog();
            Show();

            listaUsu = formuIniciar.ListUsu;
            listaUsu.GuardarFichero();
        }
    }
}
