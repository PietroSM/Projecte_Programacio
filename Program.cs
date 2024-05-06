using Projecte_programació.Pantalles;
using Projecte_programació.Persona;
using Projecte_programació.Persona.Vendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte_programació
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Usuarios usuarios = new Usuarios();
            usuarios.AnyadirPersona(new Autonomo("juan", "1234", "sant vicent",
                "juan123@gmail.com", 0, "12323"));
            usuarios.AnyadirPersona(new Cooperativa());
            Application.Run(new Pagina_Benvinguda(usuarios));

        }
    }
}
