namespace DesafioEntregable_C
{
    partial class frmVenta_agregar
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
            label1 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            txtComentarios = new TextBox();
            numIdUsuario = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(377, 153);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Comentarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 262);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Id del Usuario";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(352, 332);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 74);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Nueva Venta";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(313, 171);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(211, 23);
            txtComentarios.TabIndex = 4;
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(352, 280);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(120, 23);
            numIdUsuario.TabIndex = 5;
            // 
            // frmVenta_agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(numIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmVenta_agregar";
            Text = "frmVenta_agregar";
            ((System.ComponentModel.ISupportInitialize)numIdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAgregar;
        private TextBox txtComentarios;
        private NumericUpDown numIdUsuario;
    }
}