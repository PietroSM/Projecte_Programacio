namespace Projecte_programació.Pantalles
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
            this.iniciar_sessio = new System.Windows.Forms.Button();
            this.Registrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciar_sessio
            // 
            this.iniciar_sessio.Location = new System.Drawing.Point(470, 192);
            this.iniciar_sessio.Name = "iniciar_sessio";
            this.iniciar_sessio.Size = new System.Drawing.Size(141, 67);
            this.iniciar_sessio.TabIndex = 0;
            this.iniciar_sessio.Text = "Log_In";
            this.iniciar_sessio.UseVisualStyleBackColor = true;
            // 
            // Registrarse
            // 
            this.Registrarse.Location = new System.Drawing.Point(137, 192);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(136, 65);
            this.Registrarse.TabIndex = 1;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // Pagina_Benvinguda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.iniciar_sessio);
            this.Name = "Pagina_Benvinguda";
            this.Text = "Pagina_Benvinguda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iniciar_sessio;
        private System.Windows.Forms.Button Registrarse;
    }
}