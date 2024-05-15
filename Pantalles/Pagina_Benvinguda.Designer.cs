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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iniciar_sessio
            // 
            this.iniciar_sessio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.iniciar_sessio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iniciar_sessio.FlatAppearance.BorderSize = 2;
            this.iniciar_sessio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciar_sessio.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar_sessio.ForeColor = System.Drawing.Color.White;
            this.iniciar_sessio.Location = new System.Drawing.Point(1112, 644);
            this.iniciar_sessio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iniciar_sessio.Name = "iniciar_sessio";
            this.iniciar_sessio.Size = new System.Drawing.Size(379, 69);
            this.iniciar_sessio.TabIndex = 0;
            this.iniciar_sessio.Text = "Iniciar Sessión";
            this.iniciar_sessio.UseVisualStyleBackColor = false;
            this.iniciar_sessio.Click += new System.EventHandler(this.iniciar_sessio_Click);
            // 
            // Registrarse
            // 
            this.Registrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.Registrarse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Registrarse.FlatAppearance.BorderSize = 2;
            this.Registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrarse.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarse.ForeColor = System.Drawing.Color.White;
            this.Registrarse.Location = new System.Drawing.Point(252, 644);
            this.Registrarse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(379, 69);
            this.Registrarse.TabIndex = 1;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = false;
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(567, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "WOLLA-DONA";
            // 
            // Pagina_Benvinguda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1845, 998);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.iniciar_sessio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pagina_Benvinguda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina_Benvinguda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciar_sessio;
        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.Label label1;
    }
}