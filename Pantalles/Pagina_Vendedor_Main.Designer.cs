namespace Projecte_programació.Pantalles
{
    partial class Pagina_Vendedor_Main
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
            this.label8 = new System.Windows.Forms.Label();
            this.BTNanyadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(577, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(586, 91);
            this.label8.TabIndex = 12;
            this.label8.Text = "WOLLA-DONA";
            // 
            // BTNanyadir
            // 
            this.BTNanyadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.BTNanyadir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNanyadir.FlatAppearance.BorderSize = 2;
            this.BTNanyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNanyadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNanyadir.ForeColor = System.Drawing.Color.White;
            this.BTNanyadir.Location = new System.Drawing.Point(1446, 77);
            this.BTNanyadir.Name = "BTNanyadir";
            this.BTNanyadir.Size = new System.Drawing.Size(187, 89);
            this.BTNanyadir.TabIndex = 13;
            this.BTNanyadir.Text = "AÑADIR PRODUCTO";
            this.BTNanyadir.UseVisualStyleBackColor = false;
            // 
            // Pagina_Vendedor_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1845, 998);
            this.Controls.Add(this.BTNanyadir);
            this.Controls.Add(this.label8);
            this.Name = "Pagina_Vendedor_Main";
            this.Text = "Pagina_Vendedor_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTNanyadir;
    }
}