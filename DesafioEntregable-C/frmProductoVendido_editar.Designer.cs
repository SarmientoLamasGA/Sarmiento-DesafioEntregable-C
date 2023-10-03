namespace DesafioEntregable_C
{
    partial class frmProductoVendido_editar
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
            // btnEditar
            // 
            btnEditar.Location = new Point(295, 319);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(193, 63);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Modificar Venta";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 229);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 18;
            label3.Text = "ID del Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 137);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 17;
            label2.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 62);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 16;
            label1.Text = "ID del Producto";
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(341, 247);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(120, 23);
            numIdUsuario.TabIndex = 15;
            // 
            // numStock
            // 
            numStock.Location = new Point(341, 155);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 14;
            // 
            // numIdProducto
            // 
            numIdProducto.Location = new Point(341, 80);
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(120, 23);
            numIdProducto.TabIndex = 13;
            // 
            // frmProductoVendido_editar
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
            Controls.Add(btnEditar);
            Name = "frmProductoVendido_editar";
            Text = "frmProductoVendido_editar";
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditar;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numIdUsuario;
        private NumericUpDown numStock;
        private NumericUpDown numIdProducto;
    }
}