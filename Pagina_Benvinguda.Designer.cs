namespace Projecte_programació
{
    partial class Pagina_Benvinguda
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
            this.Iniciar_sesion = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Iniciar_sesion
            // 
            this.Iniciar_sesion.Location = new System.Drawing.Point(240, 305);
            this.Iniciar_sesion.Name = "Iniciar_sesion";
            this.Iniciar_sesion.Size = new System.Drawing.Size(220, 100);
            this.Iniciar_sesion.TabIndex = 0;
            this.Iniciar_sesion.Text = "Iniciar_Sesion";
            this.Iniciar_sesion.UseVisualStyleBackColor = true;
            this.Iniciar_sesion.Click += new System.EventHandler(this.Iniciar_sesion_Click);
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(645, 305);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(220, 100);
            this.Registrar.TabIndex = 1;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 735);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.Iniciar_sesion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Iniciar_sesion;
        private System.Windows.Forms.Button Registrar;
    }
}

