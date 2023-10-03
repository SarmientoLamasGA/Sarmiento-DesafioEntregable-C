namespace DesafioEntregable_C
{
    partial class frmVenta_borrar
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
            numIdUsuario = new NumericUpDown();
            txtComentarios = new TextBox();
            btnEliminar = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(334, 226);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(120, 23);
            numIdUsuario.TabIndex = 10;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(295, 117);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(211, 23);
            txtComentarios.TabIndex = 9;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(334, 278);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 74);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Borrar venta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 208);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 7;
            label2.Text = "Id del Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 99);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 6;
            label1.Text = "Comentarios";
            // 
            // frmVenta_borrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(numIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmVenta_borrar";
            Text = "frmVenta_borrar";
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numIdUsuario;
        private TextBox txtComentarios;
        private Button btnEliminar;
        private Label label2;
        private Label label1;
    }
}