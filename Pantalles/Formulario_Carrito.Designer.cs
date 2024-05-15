namespace Projecte_programació.Pantalles
{
    partial class Formulario_Carrito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.temporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTNback = new System.Windows.Forms.Button();
            this.BTNcompra = new System.Windows.Forms.Button();
            this.TBprecioTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label8.TabIndex = 14;
            this.label8.Text = "WOLLA-DONA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.temporadaDataGridViewTextBoxColumn,
            this.precioKgDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoABindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(553, 196);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(709, 704);
            this.dataGridView1.TabIndex = 15;
            // 
            // temporadaDataGridViewTextBoxColumn
            // 
            this.temporadaDataGridViewTextBoxColumn.DataPropertyName = "Temporada";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.temporadaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.temporadaDataGridViewTextBoxColumn.HeaderText = "Temporada";
            this.temporadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temporadaDataGridViewTextBoxColumn.Name = "temporadaDataGridViewTextBoxColumn";
            this.temporadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.temporadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioKgDataGridViewTextBoxColumn
            // 
            this.precioKgDataGridViewTextBoxColumn.DataPropertyName = "PrecioKg";
            this.precioKgDataGridViewTextBoxColumn.HeaderText = "PrecioKg";
            this.precioKgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioKgDataGridViewTextBoxColumn.Name = "precioKgDataGridViewTextBoxColumn";
            this.precioKgDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioKgDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
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
            this.BTNback.TabIndex = 27;
            this.BTNback.Text = "Volver";
            this.BTNback.UseVisualStyleBackColor = false;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // BTNcompra
            // 
            this.BTNcompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.BTNcompra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNcompra.FlatAppearance.BorderSize = 3;
            this.BTNcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcompra.ForeColor = System.Drawing.Color.White;
            this.BTNcompra.Location = new System.Drawing.Point(1603, 736);
            this.BTNcompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNcompra.Name = "BTNcompra";
            this.BTNcompra.Size = new System.Drawing.Size(172, 54);
            this.BTNcompra.TabIndex = 28;
            this.BTNcompra.Text = "Comprar";
            this.BTNcompra.UseVisualStyleBackColor = false;
            this.BTNcompra.Click += new System.EventHandler(this.BTNcompra_Click);
            // 
            // TBprecioTotal
            // 
            this.TBprecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBprecioTotal.Location = new System.Drawing.Point(1351, 743);
            this.TBprecioTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBprecioTotal.Name = "TBprecioTotal";
            this.TBprecioTotal.Size = new System.Drawing.Size(197, 46);
            this.TBprecioTotal.TabIndex = 29;
            // 
            // Formulario_Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1845, 998);
            this.Controls.Add(this.TBprecioTotal);
            this.Controls.Add(this.BTNcompra);
            this.Controls.Add(this.BTNback);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Formulario_Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario_Carrito";
            this.Load += new System.EventHandler(this.Formulario_Carrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNback;
        private System.Windows.Forms.BindingSource productoABindingSource;
        private System.Windows.Forms.Button BTNcompra;
        private System.Windows.Forms.TextBox TBprecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}