using Projecte_programació.Persona;
using Projecte_programació.Persona.Vendedor;
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
    public partial class Iniciar_Sessio : Form
    {
        Pagina_Vendedor_Main paginaVendedor;
        private Usuarios listUsu;

        public Iniciar_Sessio(Usuarios usu)
        {
            InitializeComponent();
            listUsu = usu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correoTB, contrasenyaTB;

            correoTB = TBnombre.Text;
            contrasenyaTB = TBcontra.Text;


            if (!string.IsNullOrWhiteSpace(TBnombre.Text)
                && listUsu.ComprovarCredenciales(correoTB,contrasenyaTB))
            {
                if(listUsu.tipoUsuario(correoTB) == "vendedor")
                {
                    paginaVendedor = new Pagina_Vendedor_Main(
                        listUsu, listUsu.PosicionLista(correoTB));
                    paginaVendedor.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Correo o Contraseña erronea");
            }
        }
    }
}
