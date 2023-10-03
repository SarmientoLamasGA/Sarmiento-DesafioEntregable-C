namespace DesafioEntregable_C
{
    partial class frmProductoVendido_agregar
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
            btnAgregar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numIdUsuario = new NumericUpDown();
            numStock = new NumericUpDown();
            numIdProducto = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(304, 318);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(193, 63);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Nueva Venta";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 237);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 12;
            label3.Text = "ID del Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 145);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 70);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 10;
            label1.Text = "ID del Producto";
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(340, 255);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(120, 23);
            numIdUsuario.TabIndex = 9;
            // 
            // numStock
            // 
            numStock.Location = new Point(340, 163);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 8;
            // 
            // numIdProducto
            // 
            numIdProducto.Location = new Point(340, 88);
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(120, 23);
            numIdProducto.TabIndex = 7;
            // 
            // frmProductoVendido_agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numIdUsuario);
            Controls.Add(numStock);
            Controls.Add(numIdProducto);
            Name = "frmProductoVendido_agregar";
            Text = "frmProductoVendido_agregar";
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numIdUsuario;
        private NumericUpDown numStock;
        private NumericUpDown numIdProducto;
    }
}