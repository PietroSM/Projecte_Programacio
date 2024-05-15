namespace Projecte_programació.Pantalles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.temporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBcolum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productoABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTNcarrito = new System.Windows.Forms.Button();
            this.BTNback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(617, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(586, 91);
            this.label8.TabIndex = 13;
            this.label8.Text = "WOLLA-DONA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.temporadaDataGridViewTextBoxColumn,
            this.precioKgDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.CBcolum});
            this.dataGridView1.DataSource = this.productoABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(513, 191);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 724);
            this.dataGridView1.TabIndex = 14;
            // 
            // temporadaDataGridViewTextBoxColumn
            // 
            this.temporadaDataGridViewTextBoxColumn.DataPropertyName = "Temporada";
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
            // CBcolum
            // 
            this.CBcolum.DataPropertyName = "Comprar";
            this.CBcolum.HeaderText = "Añadir";
            this.CBcolum.MinimumWidth = 6;
            this.CBcolum.Name = "CBcolum";
            this.CBcolum.Width = 125;
            // 
            // productoABindingSource
            // 
            this.productoABindingSource.DataSource = typeof(Projecte_programació.Producto.ProductoA);
            // 
            // BTNcarrito
            // 
            this.BTNcarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.BTNcarrito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNcarrito.FlatAppearance.BorderSize = 4;
            this.BTNcarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcarrito.ForeColor = System.Drawing.Color.White;
            this.BTNcarrito.Location = new System.Drawing.Point(1556, 66);
            this.BTNcarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNcarrito.Name = "BTNcarrito";
            this.BTNcarrito.Size = new System.Drawing.Size(131, 78);
            this.BTNcarrito.TabIndex = 15;
            this.BTNcarrito.Text = "Carrito";
            this.BTNcarrito.UseVisualStyleBackColor = false;
            this.BTNcarrito.Click += new System.EventHandler(this.BTNcarrito_Click);
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
            this.BTNback.TabIndex = 28;
            this.BTNback.Text = "Volver";
            this.BTNback.UseVisualStyleBackColor = false;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // Pagina_Client_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1845, 998);
            this.Controls.Add(this.BTNback);
            this.Controls.Add(this.BTNcarrito);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pagina_Client_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button BTNcarrito;
        private System.Windows.Forms.Button BTNback;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CBcolum;
    }
}