namespace DesafioEntregable_C
{
    partial class frmProducto_editar
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
            btnEditar = new Button();
            STOCK = new Label();
            ID_USUARIO = new Label();
            VENTA = new Label();
            COSTO = new Label();
            DESCRIPCION = new Label();
            txtIdUsuario = new TextBox();
            numStock = new NumericUpDown();
            numPrecioVenta = new NumericUpDown();
            numCosto = new NumericUpDown();
            txtDescripciones = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(307, 359);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(169, 60);
            btnEditar.TabIndex = 57;
            btnEditar.Text = "Editar Producto";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // STOCK
            // 
            STOCK.AutoSize = true;
            STOCK.BackColor = Color.AliceBlue;
            STOCK.Location = new Point(369, 231);
            STOCK.Name = "STOCK";
            STOCK.Size = new Size(42, 15);
            STOCK.TabIndex = 67;
            STOCK.Text = "STOCK";
            // 
            // ID_USUARIO
            // 
            ID_USUARIO.AutoSize = true;
            ID_USUARIO.BackColor = Color.AliceBlue;
            ID_USUARIO.Location = new Point(356, 290);
            ID_USUARIO.Name = "ID_USUARIO";
            ID_USUARIO.Size = new Size(70, 15);
            ID_USUARIO.TabIndex = 66;
            ID_USUARIO.Text = "ID USUARIO";
            // 
            // VENTA
            // 
            VENTA.AutoSize = true;
            VENTA.BackColor = Color.AliceBlue;
            VENTA.Location = new Point(369, 168);
            VENTA.Name = "VENTA";
            VENTA.Size = new Size(42, 15);
            VENTA.TabIndex = 65;
            VENTA.Text = "VENTA";
            // 
            // COSTO
            // 
            COSTO.AutoSize = true;
            COSTO.BackColor = Color.AliceBlue;
            COSTO.Location = new Point(369, 103);
            COSTO.Name = "COSTO";
            COSTO.Size = new Size(44, 15);
            COSTO.TabIndex = 64;
            COSTO.Text = "COSTO";
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.AutoSize = true;
            DESCRIPCION.BackColor = SystemColors.ButtonHighlight;
            DESCRIPCION.Location = new Point(356, 31);
            DESCRIPCION.Name = "DESCRIPCION";
            DESCRIPCION.Size = new Size(81, 15);
            DESCRIPCION.TabIndex = 63;
            DESCRIPCION.Text = "DESCRIPCION";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(266, 308);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(250, 23);
            txtIdUsuario.TabIndex = 62;
            // 
            // numStock
            // 
            numStock.Location = new Point(266, 249);
            numStock.Name = "numStock";
            numStock.Size = new Size(250, 23);
            numStock.TabIndex = 61;
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.Location = new Point(266, 186);
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new Size(250, 23);
            numPrecioVenta.TabIndex = 60;
            // 
            // numCosto
            // 
            numCosto.Location = new Point(266, 121);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(250, 23);
            numCosto.TabIndex = 59;
            // 
            // txtDescripciones
            // 
            txtDescripciones.Location = new Point(266, 49);
            txtDescripciones.Name = "txtDescripciones";
            txtDescripciones.Size = new Size(250, 23);
            txtDescripciones.TabIndex = 58;
            // 
            // frmProducto_editar
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
            Controls.Add(txtDescripciones);
            Controls.Add(btnEditar);
            Name = "frmProducto_editar";
            Text = "frmProducto_editar";
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditar;
        private Label STOCK;
        private Label ID_USUARIO;
        private Label VENTA;
        private Label COSTO;
        private Label DESCRIPCION;
        private TextBox txtIdUsuario;
        private NumericUpDown numStock;
        private NumericUpDown numPrecioVenta;
        private NumericUpDown numCosto;
        private TextBox txtDescripciones;
    }
}