﻿namespace Projecte_programació.Pantalles
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNanyadir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productoABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.verduraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTNback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verduraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoABindingSource)).BeginInit();
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
            this.BTNanyadir.Click += new System.EventHandler(this.BTNanyadir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.propietarioDataGridViewTextBoxColumn,
            this.temporadaDataGridViewTextBoxColumn,
            this.precioKgDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dataGridView1.DataSource = this.productoABindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(149, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1484, 705);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // propietarioDataGridViewTextBoxColumn
            // 
            this.propietarioDataGridViewTextBoxColumn.DataPropertyName = "Propietario";
            this.propietarioDataGridViewTextBoxColumn.HeaderText = "Propietario";
            this.propietarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.propietarioDataGridViewTextBoxColumn.Name = "propietarioDataGridViewTextBoxColumn";
            this.propietarioDataGridViewTextBoxColumn.Visible = false;
            this.propietarioDataGridViewTextBoxColumn.Width = 200;
            // 
            // temporadaDataGridViewTextBoxColumn
            // 
            this.temporadaDataGridViewTextBoxColumn.DataPropertyName = "Temporada";
            this.temporadaDataGridViewTextBoxColumn.HeaderText = "Temporada";
            this.temporadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temporadaDataGridViewTextBoxColumn.Name = "temporadaDataGridViewTextBoxColumn";
            this.temporadaDataGridViewTextBoxColumn.Width = 200;
            // 
            // precioKgDataGridViewTextBoxColumn
            // 
            this.precioKgDataGridViewTextBoxColumn.DataPropertyName = "PrecioKg";
            this.precioKgDataGridViewTextBoxColumn.HeaderText = "PrecioKg";
            this.precioKgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioKgDataGridViewTextBoxColumn.Name = "precioKgDataGridViewTextBoxColumn";
            this.precioKgDataGridViewTextBoxColumn.Width = 200;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 200;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Elimina";
            this.Eliminar.Width = 200;
            // 
            // productoABindingSource1
            // 
            this.productoABindingSource1.DataSource = typeof(Projecte_programació.Producto.ProductoA);
            // 
            // verduraBindingSource
            // 
            this.verduraBindingSource.DataSource = typeof(Projecte_programació.Producto.Verdura);
            // 
            // productoABindingSource
            // 
            this.productoABindingSource.DataSource = typeof(Projecte_programació.Producto.ProductoA);
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
            // Pagina_Vendedor_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1845, 998);
            this.Controls.Add(this.BTNback);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNanyadir);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pagina_Vendedor_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pagina_Vendedor_Main";
            this.Load += new System.EventHandler(this.Pagina_Vendedor_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verduraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTNanyadir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productoABindingSource;
        private System.Windows.Forms.BindingSource verduraBindingSource;
        private System.Windows.Forms.BindingSource productoABindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button BTNback;
    }
}