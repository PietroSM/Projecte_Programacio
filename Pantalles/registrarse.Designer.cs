namespace Projecte_programació.Pantalles
{
    partial class registrarse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RBVendedor = new System.Windows.Forms.RadioButton();
            this.RBCliente = new System.Windows.Forms.RadioButton();
            this.labelVendedorCIF = new System.Windows.Forms.Label();
            this.labelClienteCIF = new System.Windows.Forms.Label();
            this.labelClienteDNI = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBContrasenya = new System.Windows.Forms.TextBox();
            this.TBLocalizacion = new System.Windows.Forms.TextBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.TBcifClient = new System.Windows.Forms.TextBox();
            this.TBdniClient = new System.Windows.Forms.TextBox();
            this.TBcifVendedor = new System.Windows.Forms.TextBox();
            this.GRautocoope = new System.Windows.Forms.GroupBox();
            this.RBcooperativa = new System.Windows.Forms.RadioButton();
            this.RBautonomo = new System.Windows.Forms.RadioButton();
            this.BTNback = new System.Windows.Forms.Button();
            this.GRautocoope.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(236, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(968, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Localización";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1029, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            // 
            // RBVendedor
            // 
            this.RBVendedor.AutoSize = true;
            this.RBVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBVendedor.ForeColor = System.Drawing.Color.White;
            this.RBVendedor.Location = new System.Drawing.Point(1252, 405);
            this.RBVendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RBVendedor.Name = "RBVendedor";
            this.RBVendedor.Size = new System.Drawing.Size(148, 33);
            this.RBVendedor.TabIndex = 4;
            this.RBVendedor.TabStop = true;
            this.RBVendedor.Text = "Vendedor";
            this.RBVendedor.UseVisualStyleBackColor = true;
            this.RBVendedor.CheckedChanged += new System.EventHandler(this.RBVendedor_CheckedChanged);
            // 
            // RBCliente
            // 
            this.RBCliente.AutoSize = true;
            this.RBCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCliente.ForeColor = System.Drawing.Color.White;
            this.RBCliente.Location = new System.Drawing.Point(539, 405);
            this.RBCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RBCliente.Name = "RBCliente";
            this.RBCliente.Size = new System.Drawing.Size(117, 33);
            this.RBCliente.TabIndex = 5;
            this.RBCliente.TabStop = true;
            this.RBCliente.Text = "Cliente";
            this.RBCliente.UseVisualStyleBackColor = true;
            this.RBCliente.CheckedChanged += new System.EventHandler(this.RBCliente_CheckedChanged);
            // 
            // labelVendedorCIF
            // 
            this.labelVendedorCIF.AutoSize = true;
            this.labelVendedorCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedorCIF.ForeColor = System.Drawing.Color.White;
            this.labelVendedorCIF.Location = new System.Drawing.Point(1087, 464);
            this.labelVendedorCIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendedorCIF.Name = "labelVendedorCIF";
            this.labelVendedorCIF.Size = new System.Drawing.Size(54, 29);
            this.labelVendedorCIF.TabIndex = 6;
            this.labelVendedorCIF.Text = "CIF";
            // 
            // labelClienteCIF
            // 
            this.labelClienteCIF.AutoSize = true;
            this.labelClienteCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteCIF.ForeColor = System.Drawing.Color.White;
            this.labelClienteCIF.Location = new System.Drawing.Point(335, 464);
            this.labelClienteCIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClienteCIF.Name = "labelClienteCIF";
            this.labelClienteCIF.Size = new System.Drawing.Size(54, 29);
            this.labelClienteCIF.TabIndex = 7;
            this.labelClienteCIF.Text = "CIF";
            // 
            // labelClienteDNI
            // 
            this.labelClienteDNI.AutoSize = true;
            this.labelClienteDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteDNI.ForeColor = System.Drawing.Color.White;
            this.labelClienteDNI.Location = new System.Drawing.Point(332, 548);
            this.labelClienteDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClienteDNI.Name = "labelClienteDNI";
            this.labelClienteDNI.Size = new System.Drawing.Size(57, 29);
            this.labelClienteDNI.TabIndex = 8;
            this.labelClienteDNI.Text = "DNI";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 2;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnRegistrar.Location = new System.Drawing.Point(825, 726);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(236, 63);
            this.BtnRegistrar.TabIndex = 9;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BotoRegistrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(585, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(586, 91);
            this.label8.TabIndex = 10;
            this.label8.Text = "WOLLA-DONA";
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(464, 215);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(275, 34);
            this.TBNombre.TabIndex = 11;
            // 
            // TBContrasenya
            // 
            this.TBContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContrasenya.Location = new System.Drawing.Point(464, 316);
            this.TBContrasenya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBContrasenya.Name = "TBContrasenya";
            this.TBContrasenya.Size = new System.Drawing.Size(275, 34);
            this.TBContrasenya.TabIndex = 12;
            // 
            // TBLocalizacion
            // 
            this.TBLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLocalizacion.Location = new System.Drawing.Point(1212, 215);
            this.TBLocalizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBLocalizacion.Name = "TBLocalizacion";
            this.TBLocalizacion.Size = new System.Drawing.Size(275, 34);
            this.TBLocalizacion.TabIndex = 13;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreo.Location = new System.Drawing.Point(1212, 316);
            this.TBCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(275, 34);
            this.TBCorreo.TabIndex = 14;
            // 
            // TBcifClient
            // 
            this.TBcifClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcifClient.Location = new System.Drawing.Point(464, 460);
            this.TBcifClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBcifClient.Name = "TBcifClient";
            this.TBcifClient.Size = new System.Drawing.Size(275, 34);
            this.TBcifClient.TabIndex = 15;
            // 
            // TBdniClient
            // 
            this.TBdniClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdniClient.Location = new System.Drawing.Point(459, 544);
            this.TBdniClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBdniClient.Name = "TBdniClient";
            this.TBdniClient.Size = new System.Drawing.Size(280, 34);
            this.TBdniClient.TabIndex = 16;
            // 
            // TBcifVendedor
            // 
            this.TBcifVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcifVendedor.Location = new System.Drawing.Point(1212, 460);
            this.TBcifVendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBcifVendedor.Name = "TBcifVendedor";
            this.TBcifVendedor.Size = new System.Drawing.Size(276, 34);
            this.TBcifVendedor.TabIndex = 17;
            // 
            // GRautocoope
            // 
            this.GRautocoope.Controls.Add(this.RBcooperativa);
            this.GRautocoope.Controls.Add(this.RBautonomo);
            this.GRautocoope.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GRautocoope.Location = new System.Drawing.Point(1092, 548);
            this.GRautocoope.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GRautocoope.Name = "GRautocoope";
            this.GRautocoope.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GRautocoope.Size = new System.Drawing.Size(436, 76);
            this.GRautocoope.TabIndex = 20;
            this.GRautocoope.TabStop = false;
            // 
            // RBcooperativa
            // 
            this.RBcooperativa.AutoSize = true;
            this.RBcooperativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBcooperativa.ForeColor = System.Drawing.Color.White;
            this.RBcooperativa.Location = new System.Drawing.Point(227, 23);
            this.RBcooperativa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RBcooperativa.Name = "RBcooperativa";
            this.RBcooperativa.Size = new System.Drawing.Size(175, 33);
            this.RBcooperativa.TabIndex = 1;
            this.RBcooperativa.TabStop = true;
            this.RBcooperativa.Text = "Cooperativa";
            this.RBcooperativa.UseVisualStyleBackColor = true;
            // 
            // RBautonomo
            // 
            this.RBautonomo.AutoSize = true;
            this.RBautonomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBautonomo.ForeColor = System.Drawing.Color.White;
            this.RBautonomo.Location = new System.Drawing.Point(29, 23);
            this.RBautonomo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RBautonomo.Name = "RBautonomo";
            this.RBautonomo.Size = new System.Drawing.Size(151, 33);
            this.RBautonomo.TabIndex = 0;
            this.RBautonomo.TabStop = true;
            this.RBautonomo.Text = "Autonomo";
            this.RBautonomo.UseVisualStyleBackColor = true;
            // 
            // BTNback
            // 
            this.BTNback.BackColor = System.Drawing.Color.Orange;
            this.BTNback.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNback.FlatAppearance.BorderSize = 4;
            this.BTNback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNback.ForeColor = System.Drawing.Color.White;
            this.BTNback.Location = new System.Drawing.Point(85, 66);
            this.BTNback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNback.Name = "BTNback";
            this.BTNback.Size = new System.Drawing.Size(131, 78);
            this.BTNback.TabIndex = 29;
            this.BTNback.Text = "Volver";
            this.BTNback.UseVisualStyleBackColor = false;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1845, 998);
            this.Controls.Add(this.BTNback);
            this.Controls.Add(this.GRautocoope);
            this.Controls.Add(this.TBcifVendedor);
            this.Controls.Add(this.TBdniClient);
            this.Controls.Add(this.TBcifClient);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.TBLocalizacion);
            this.Controls.Add(this.TBContrasenya);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.labelClienteDNI);
            this.Controls.Add(this.labelClienteCIF);
            this.Controls.Add(this.labelVendedorCIF);
            this.Controls.Add(this.RBCliente);
            this.Controls.Add(this.RBVendedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "registrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "registrarse";
            this.GRautocoope.ResumeLayout(false);
            this.GRautocoope.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RBVendedor;
        private System.Windows.Forms.RadioButton RBCliente;
        private System.Windows.Forms.Label labelVendedorCIF;
        private System.Windows.Forms.Label labelClienteCIF;
        private System.Windows.Forms.Label labelClienteDNI;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBContrasenya;
        private System.Windows.Forms.TextBox TBLocalizacion;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.TextBox TBcifClient;
        private System.Windows.Forms.TextBox TBdniClient;
        private System.Windows.Forms.TextBox TBcifVendedor;
        private System.Windows.Forms.GroupBox GRautocoope;
        private System.Windows.Forms.RadioButton RBautonomo;
        private System.Windows.Forms.RadioButton RBcooperativa;
        private System.Windows.Forms.Button BTNback;
    }
}