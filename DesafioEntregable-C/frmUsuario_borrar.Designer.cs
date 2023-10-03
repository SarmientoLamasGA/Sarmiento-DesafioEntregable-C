namespace DesafioEntregable_C
{
    partial class frmUsuario_borrar
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
            txtContraseña = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            Contraseña = new Label();
            Mail = new Label();
            UserName = new Label();
            Costo = new Label();
            Nombre = new Label();
            txtMail = new TextBox();
            btnEliminar = new Button();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(276, 249);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(250, 23);
            txtContraseña.TabIndex = 46;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(276, 189);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(250, 23);
            txtNombreUsuario.TabIndex = 45;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(276, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 23);
            txtApellido.TabIndex = 44;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.BackColor = Color.AliceBlue;
            Contraseña.Location = new Point(276, 231);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(67, 15);
            Contraseña.TabIndex = 43;
            Contraseña.Text = "Contraseña";
            // 
            // Mail
            // 
            Mail.AutoSize = true;
            Mail.BackColor = Color.AliceBlue;
            Mail.Location = new Point(276, 287);
            Mail.Name = "Mail";
            Mail.Size = new Size(30, 15);
            Mail.TabIndex = 42;
            Mail.Text = "Mail";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.BackColor = Color.AliceBlue;
            UserName.Location = new Point(276, 171);
            UserName.Name = "UserName";
            UserName.Size = new Size(110, 15);
            UserName.TabIndex = 41;
            UserName.Text = "Nombre de Usuario";
            // 
            // Costo
            // 
            Costo.AutoSize = true;
            Costo.BackColor = Color.AliceBlue;
            Costo.Location = new Point(274, 107);
            Costo.Name = "Costo";
            Costo.Size = new Size(51, 15);
            Costo.TabIndex = 40;
            Costo.Text = "Apellido";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = SystemColors.ButtonHighlight;
            Nombre.Location = new Point(276, 38);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 39;
            Nombre.Text = "Nombre";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(276, 305);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(250, 23);
            txtMail.TabIndex = 38;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(334, 362);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 51);
            btnEliminar.TabIndex = 37;
            btnEliminar.Text = "Borrar usuario";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(276, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 36;
            // 
            // frmUsuario_borrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(Contraseña);
            Controls.Add(Mail);
            Controls.Add(UserName);
            Controls.Add(Costo);
            Controls.Add(Nombre);
            Controls.Add(txtMail);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombre);
            Name = "frmUsuario_borrar";
            Text = "frmUsuario_borrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContraseña;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private Label Contraseña;
        private Label Mail;
        private Label UserName;
        private Label Costo;
        private Label Nombre;
        private TextBox txtMail;
        private Button btnEliminar;
        private TextBox txtNombre;
    }
}