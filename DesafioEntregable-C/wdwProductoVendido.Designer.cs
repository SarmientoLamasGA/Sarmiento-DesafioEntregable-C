namespace DesafioEntregable_C
{
    partial class WdwProductoVendido
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
            dataGridView1 = new DataGridView();
            btnAgregarProductoVendido = new Button();
            Id = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdVenta = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, IdProducto, Stock, IdVenta, Editar, Eliminar });
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 350);
            dataGridView1.TabIndex = 0;
            // 
            // btnAgregarProductoVendido
            // 
            btnAgregarProductoVendido.Location = new Point(618, 12);
            btnAgregarProductoVendido.Name = "btnAgregarProductoVendido";
            btnAgregarProductoVendido.Size = new Size(170, 70);
            btnAgregarProductoVendido.TabIndex = 1;
            btnAgregarProductoVendido.Text = "Nuevo producto vendido";
            btnAgregarProductoVendido.UseVisualStyleBackColor = true;
            btnAgregarProductoVendido.Click += btnAgregarProductoVendido_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "IdProducto";
            IdProducto.HeaderText = "Producto ID";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // IdVenta
            // 
            IdVenta.DataPropertyName = "IdVenta";
            IdVenta.HeaderText = "ID de la venta";
            IdVenta.Name = "IdVenta";
            IdVenta.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.DataPropertyName = "Editar";
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.DataPropertyName = "Eliminar";
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // WdwProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarProductoVendido);
            Controls.Add(dataGridView1);
            Name = "WdwProductoVendido";
            Text = "wdwProductoVendido";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregarProductoVendido;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}