namespace DesafioEntregable_C
{
    partial class frmProductoVendido_borrar
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
            btnEliminar = new Button();
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
            // btnEliminar
            // 
            btnEliminar.Location = new Point(304, 318);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(193, 63);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar Venta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 234);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 19;
            label3.Text = "ID de la venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 142);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 18;
            label2.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 67);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 17;
            label1.Text = "ID del Producto";
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(348, 252);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(120, 23);
            numIdUsuario.TabIndex = 16;
            // 
            // numStock
            // 
            numStock.Location = new Point(348, 160);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 15;
            // 
            // numIdProducto
            // 
            numIdProducto.Location = new Point(348, 85);
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(120, 23);
            numIdProducto.TabIndex = 14;
            // 
            // frmProductoVendido_borrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numIdUsuario);
            Controls.Add(numStock);
            Controls.Add(numIdProducto);
            Controls.Add(btnEliminar);
            Name = "frmProductoVendido_borrar";
            Text = "frmProductoVendido_borrar";
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numIdUsuario;
        private NumericUpDown numStock;
        private NumericUpDown numIdProducto;
    }
}