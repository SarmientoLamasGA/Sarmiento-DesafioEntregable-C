namespace DesafioEntregable_C
{
    partial class frmProducto_agregar
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
            STOCK = new Label();
            ID_USUARIO = new Label();
            VENTA = new Label();
            COSTO = new Label();
            DESCRIPCION = new Label();
            txtIdUsuario = new TextBox();
            numStock = new NumericUpDown();
            numPrecioVenta = new NumericUpDown();
            numCosto = new NumericUpDown();
            btnAgregar = new Button();
            txtDescripciones = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            SuspendLayout();
            // 
            // STOCK
            // 
            STOCK.AutoSize = true;
            STOCK.BackColor = Color.AliceBlue;
            STOCK.Location = new Point(378, 233);
            STOCK.Name = "STOCK";
            STOCK.Size = new Size(42, 15);
            STOCK.TabIndex = 21;
            STOCK.Text = "STOCK";
            // 
            // ID_USUARIO
            // 
            ID_USUARIO.AutoSize = true;
            ID_USUARIO.BackColor = Color.AliceBlue;
            ID_USUARIO.Location = new Point(365, 292);
            ID_USUARIO.Name = "ID_USUARIO";
            ID_USUARIO.Size = new Size(70, 15);
            ID_USUARIO.TabIndex = 20;
            ID_USUARIO.Text = "ID USUARIO";
            // 
            // VENTA
            // 
            VENTA.AutoSize = true;
            VENTA.BackColor = Color.AliceBlue;
            VENTA.Location = new Point(378, 170);
            VENTA.Name = "VENTA";
            VENTA.Size = new Size(42, 15);
            VENTA.TabIndex = 19;
            VENTA.Text = "VENTA";
            // 
            // COSTO
            // 
            COSTO.AutoSize = true;
            COSTO.BackColor = Color.AliceBlue;
            COSTO.Location = new Point(378, 105);
            COSTO.Name = "COSTO";
            COSTO.Size = new Size(44, 15);
            COSTO.TabIndex = 18;
            COSTO.Text = "COSTO";
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.AutoSize = true;
            DESCRIPCION.BackColor = SystemColors.ButtonHighlight;
            DESCRIPCION.Location = new Point(365, 33);
            DESCRIPCION.Name = "DESCRIPCION";
            DESCRIPCION.Size = new Size(81, 15);
            DESCRIPCION.TabIndex = 17;
            DESCRIPCION.Text = "DESCRIPCION";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(275, 310);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(250, 23);
            txtIdUsuario.TabIndex = 16;
            // 
            // numStock
            // 
            numStock.Location = new Point(275, 251);
            numStock.Name = "numStock";
            numStock.Size = new Size(250, 23);
            numStock.TabIndex = 15;
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.Location = new Point(275, 188);
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new Size(250, 23);
            numPrecioVenta.TabIndex = 14;
            // 
            // numCosto
            // 
            numCosto.Location = new Point(275, 123);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(250, 23);
            numCosto.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(333, 367);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 51);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDescripciones
            // 
            txtDescripciones.Location = new Point(275, 51);
            txtDescripciones.Name = "txtDescripciones";
            txtDescripciones.Size = new Size(250, 23);
            txtDescripciones.TabIndex = 11;
            // 
            // frmProductos_agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(STOCK);
            Controls.Add(ID_USUARIO);
            Controls.Add(VENTA);
            Controls.Add(COSTO);
            Controls.Add(DESCRIPCION);
            Controls.Add(txtIdUsuario);
            Controls.Add(numStock);
            Controls.Add(numPrecioVenta);
            Controls.Add(numCosto);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripciones);
            Name = "frmProductos_agregar";
            Text = "frmProductos_agregar";
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label STOCK;
        private Label ID_USUARIO;
        private Label VENTA;
        private Label COSTO;
        private Label DESCRIPCION;
        private TextBox txtIdUsuario;
        private NumericUpDown numStock;
        private NumericUpDown numPrecioVenta;
        private NumericUpDown numCosto;
        private Button btnAgregar;
        private TextBox txtDescripciones;
    }
}