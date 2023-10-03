namespace DesafioEntregable_C
{
    partial class wdwBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnProductos = new Button();
            btnUsuarios = new Button();
            btnVentas = new Button();
            btnProdcutosVendidos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(507, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 37);
            label1.TabIndex = 0;
            label1.Text = "INICIO";
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.Highlight;
            btnProductos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.Location = new Point(233, 102);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(197, 88);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Ver Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.IndianRed;
            btnUsuarios.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(699, 105);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(197, 88);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Ver Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.PaleGreen;
            btnVentas.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.Location = new Point(233, 335);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(197, 88);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ver Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProdcutosVendidos
            // 
            btnProdcutosVendidos.BackColor = Color.Moccasin;
            btnProdcutosVendidos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnProdcutosVendidos.Location = new Point(699, 335);
            btnProdcutosVendidos.Name = "btnProdcutosVendidos";
            btnProdcutosVendidos.Size = new Size(197, 88);
            btnProdcutosVendidos.TabIndex = 4;
            btnProdcutosVendidos.Text = "Ver Productos Vendidos";
            btnProdcutosVendidos.UseVisualStyleBackColor = false;
            btnProdcutosVendidos.Click += btnProdcutosVendidos_Click;
            // 
            // wdwBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1140, 591);
            Controls.Add(btnProdcutosVendidos);
            Controls.Add(btnVentas);
            Controls.Add(btnUsuarios);
            Controls.Add(btnProductos);
            Controls.Add(label1);
            Name = "wdwBase";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProductos;
        private Button btnUsuarios;
        private Button btnVentas;
        private Button btnProdcutosVendidos;
    }
}