using Projecte_programació.Persona;
using Projecte_programació.Persona.Cliente;
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
    public partial class registrarse : Form
    {
        private Usuarios listaUsu;


        public registrarse(Usuarios usu)
        {
            InitializeComponent();
            listaUsu = usu;
        }



        private void BotoRegistrar_Click(object sender, EventArgs e)
        {
            string nombre, contrasenya, localizacion, correo;
            string cifCliente, dniCliente;
            string cifVendedor;


            nombre = TBNombre.Text;
            contrasenya = TBContrasenya.Text;
            localizacion = TBLocalizacion.Text;
            correo = TBCorreo.Text;

            if (RBCliente.Checked)
            {
                cifCliente = TBcifClient.Text;
                dniCliente = TBdniClient.Text;

                //Comprova si el camp de cif esta buit
                if ((string.IsNullOrWhiteSpace(TBcifClient.Text)))
                {
                    listaUsu.AnyadirPersona(new Particular(
                        nombre,contrasenya,localizacion,correo,0,dniCliente));
                }
                //Comprova si el cam de dni esta buit
                else if ((string.IsNullOrWhiteSpace(TBdniClient.Text)))
                {
                    listaUsu.AnyadirPersona(new Empresa(nombre,contrasenya,
                        localizacion,correo,1,cifCliente));
                }
            }
            else if(RBVendedor.Checked)
            {
                cifVendedor = TBcifVendedor.Text;
                if (CBAutonomo.Checked)
                {
                    listaUsu.AnyadirPersona(new Autonomo(nombre, contrasenya,
                        localizacion, correo, 3, cifVendedor));
                }
                else if(CBCooperativa.Checked)
                {
                    listaUsu.AnyadirPersona(new Cooperativa(nombre, contrasenya,
                        localizacion, correo, 4, cifVendedor));
                }
            }

            MessageBox.Show(listaUsu.MostrarDatos1(0));
        }
    }
}
