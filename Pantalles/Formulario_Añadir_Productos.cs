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
    public partial class Formulario_Añadir_Productos : Form
    {
        private bool cancelar;

        public Formulario_Añadir_Productos()
        {
            InitializeComponent();
            cancelar = false;
        }


        public string Nombre
        {
            get { return TBnombre.Text; }
            set { TBnombre.Text = value; }
        }

        public string Temporada
        {
            get { return TBtemporada.Text; }
            set { TBtemporada.Text = value; }
        }

        public double PrecioKg
        {
            get { return Convert.ToDouble(TBprecio.Text); }
            set { TBprecio.Text = value.ToString(); }
        }

        public int Cantidad
        {
            get { return Convert.ToInt32(NUDcantidad.Value); }
            set { NUDcantidad.Value = value; }
        }


        public bool Fruta
        {
            get { return RBfruta.Checked; }
        }

        public bool Verdura
        {
            get { return RBverdura.Checked; }
        }

        public bool Hortaliza
        {
            get { return RBhortaliza.Checked; }
        }

        public bool Cancelar
        {
            get { return cancelar; }
        }


        public void Limpiar()
        {
            Nombre = Temporada = "";
            PrecioKg = 0;
            Cantidad = 0;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            cancelar = false;
            Close();
        }

        private void BTNback_Click(object sender, EventArgs e)
        {
            cancelar = true;
            Close();
        }
    }
}
