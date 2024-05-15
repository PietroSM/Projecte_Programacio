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

            labelClienteCIF.Visible = false;
            labelClienteDNI.Visible = false;
            TBcifClient.Visible = false;
            TBdniClient.Visible = false;

            labelVendedorCIF.Visible = false;
            TBcifVendedor.Visible = false;
            GRautocoope.Visible = false;
        }


        public Usuarios ListaUsu 
        { 
            get => listaUsu;
        }

        //Controla que al pulsar el RB de cliente, muestre sus campos
        private void RBCliente_CheckedChanged(object sender, EventArgs e)
        {
            labelClienteCIF.Visible = true;
            labelClienteDNI.Visible = true;
            TBcifClient.Visible = true;
            TBdniClient.Visible = true;

            labelVendedorCIF.Visible = false;
            TBcifVendedor.Visible = false;
            GRautocoope.Visible = false;
        }

        //Controla que al pulsar el RB de vendedor, muestre sus campos
        private void RBVendedor_CheckedChanged(object sender, EventArgs e)
        {
            labelClienteCIF.Visible = false;
            labelClienteDNI.Visible = false;
            TBcifClient.Visible = false;
            TBdniClient.Visible = false;

            labelVendedorCIF.Visible = true;
            TBcifVendedor.Visible = true;
            GRautocoope.Visible = true;
        }

        //Metodo que controla el evento del click de registrar
        //Comprueva que todos lo campos obligatorios no estan vacios
        //Tambien comprueva que el correo no este ya en uso
        private void BotoRegistrar_Click(object sender, EventArgs e)
        {
            string nombre, contrasenya, localizacion, correo;
            string cifCliente, dniCliente;
            string cifVendedor;


            nombre = TBNombre.Text;
            contrasenya = TBContrasenya.Text;
            localizacion = TBLocalizacion.Text;
            correo = TBCorreo.Text;
            if(string.IsNullOrWhiteSpace(TBNombre.Text) || 
                string.IsNullOrWhiteSpace(TBContrasenya.Text) ||
                string.IsNullOrWhiteSpace(TBLocalizacion.Text) ||
                string.IsNullOrWhiteSpace(TBCorreo.Text))
            {
                MessageBox.Show("Rellena todos los campos obligatorios.");
            }
            else
            {
                if (!listaUsu.ComprovarEmail(correo))
                {
                    if (RBCliente.Checked)
                    {
                        cifCliente = TBcifClient.Text;
                        dniCliente = TBdniClient.Text;

                        //Comprova si el camp de cif esta buit
                        if ((string.IsNullOrWhiteSpace(TBcifClient.Text)))
                        {
                            listaUsu.AnyadirPersona(new Particular(
                                nombre, contrasenya, localizacion, correo, 0, dniCliente));
                        }
                        //Comprova si el cam de dni esta buit
                        else if ((string.IsNullOrWhiteSpace(TBdniClient.Text)))
                        {
                            listaUsu.AnyadirPersona(new Empresa(nombre, contrasenya,
                                localizacion, correo, 1, cifCliente));
                        }
                    }
                    else if (RBVendedor.Checked)
                    {
                        cifVendedor = TBcifVendedor.Text;
                        if (RBautonomo.Checked)
                        {
                            listaUsu.AnyadirPersona(new Autonomo(nombre, contrasenya,
                                localizacion, correo, 3, cifVendedor));
                        }
                        else if (RBcooperativa.Checked)
                        {
                            listaUsu.AnyadirPersona(new Cooperativa(nombre, contrasenya,
                                localizacion, correo, 4, cifVendedor));
                        }
                    }
                    MessageBox.Show("Se ha registrado correctamente.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Correo ya ha sido utilizado.");
                }
            }
           
        }

        //Vuelve a la pagina anterior
        private void BTNback_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
