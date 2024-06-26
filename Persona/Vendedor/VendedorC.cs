﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_programació.Persona.Vendedor
{
    public abstract class VendedorC : Persona
    {
        protected int id_vendedor;
        protected string CIF;

        public VendedorC(string nombre, string contrasenya, string localizacion, 
            string correo, int id_vendedor, string CIF) : 
            base(nombre, contrasenya, localizacion, correo)
        {
            this.id_vendedor = id_vendedor;
            this.CIF = CIF;
        }

        public VendedorC() : 
            this("","","","",0,"")
        {
        }

        public int GetId_vendedor()
        {
            return id_vendedor;
        }

        public void SetId_vendedor(int id_vendedor)
        {
            this.id_vendedor = id_vendedor;
        }

        public string GetCIF()
        {
            return CIF;
        }

        public void SetCIF(string CIF)
        {
            this.CIF = CIF;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
