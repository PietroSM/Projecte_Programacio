﻿namespace Projecte_programació.Pantalles
{
    partial class Pagina_Client_Main
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CBcolum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.propietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTNcarrito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(590, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(586, 91);
            this.label8.TabIndex = 13;
            this.label8.Text = "WOLLA-DONA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propietarioDataGridViewTextBoxColumn,
            this.temporadaDataGridViewTextBoxColumn,
            this.precioKgDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.CBcolum});
            this.dataGridView1.DataSource = this.productoABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(446, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 724);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CBcolum
            // 
            this.CBcolum.DataPropertyName = "Comprar";
            this.CBcolum.HeaderText = "Añadir";
            this.CBcolum.MinimumWidth = 6;
            this.CBcolum.Name = "CBcolum";
            this.CBcolum.Width = 125;
            // 
            // propietarioDataGridViewTextBoxColumn
            // 
            this.propietarioDataGridViewTextBoxColumn.DataPropertyName = "Propietario";
            this.propietarioDataGridViewTextBoxColumn.HeaderText = "Propietario";
            this.propietarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.propietarioDataGridViewTextBoxColumn.Name = "propietarioDataGridViewTextBoxColumn";
            this.propietarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // temporadaDataGridViewTextBoxColumn
            // 
            this.temporadaDataGridViewTextBoxColumn.DataPropertyName = "Temporada";
            this.temporadaDataGridViewTextBoxColumn.HeaderText = "Temporada";
            this.temporadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temporadaDataGridViewTextBoxColumn.Name = "temporadaDataGridViewTextBoxColumn";
            this.temporadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioKgDataGridViewTextBoxColumn
            // 
            this.precioKgDataGridViewTextBoxColumn.DataPropertyName = "PrecioKg";
            this.precioKgDataGridViewTextBoxColumn.HeaderText = "PrecioKg";
            this.precioKgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioKgDataGridViewTextBoxColumn.Name = "precioKgDataGridViewTextBoxColumn";
            this.precioKgDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // productoABindingSource
            // 
            this.productoABindingSource.DataSource = typeof(Projecte_programació.Producto.ProductoA);
            // 
            // BTNcarrito
            // 
            this.BTNcarrito.Location = new System.Drawing.Point(1556, 72);
            this.BTNcarrito.Name = "BTNcarrito";
            this.BTNcarrito.Size = new System.Drawing.Size(160, 91);
            this.BTNcarrito.TabIndex = 15;
            this.BTNcarrito.Text = "Carrtio";
            this.BTNcarrito.UseVisualStyleBackColor = true;
            this.BTNcarrito.Click += new System.EventHandler(this.BTNcarrito_Click);
            // 
            // Pagina_Client_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1845, 998);
            this.Controls.Add(this.BTNcarrito);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Name = "Pagina_Client_Main";
            this.Text = "Pagina_Client_Main";
            this.Load += new System.EventHandler(this.Pagina_Client_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource productoABindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn propietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CBcolum;
        private System.Windows.Forms.Button BTNcarrito;
    }
}