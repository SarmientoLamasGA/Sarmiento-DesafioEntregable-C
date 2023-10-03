namespace DesafioEntregable_C
{
    partial class frmUsuario_agregar
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
            Contraseña = new Label();
            Mail = new Label();
            UserName = new Label();
            Costo = new Label();
            Nombre = new Label();
            txtMail = new TextBox();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.BackColor = Color.AliceBlue;
            Contraseña.Location = new Point(275, 236);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(67, 15);
            Contraseña.TabIndex = 32;
            Contraseña.Text = "Contraseña";
            // 
            // Mail
            // 
            Mail.AutoSize = true;
            Mail.BackColor = Color.AliceBlue;
            Mail.Location = new Point(275, 292);
            Mail.Name = "Mail";
            Mail.Size = new Size(30, 15);
            Mail.TabIndex = 31;
            Mail.Text = "Mail";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.BackColor = Color.AliceBlue;
            UserName.Location = new Point(275, 176);
            UserName.Name = "UserName";
            UserName.Size = new Size(110, 15);
            UserName.TabIndex = 30;
            UserName.Text = "Nombre de Usuario";
            // 
            // Costo
            // 
            Costo.AutoSize = true;
            Costo.BackColor = Color.AliceBlue;
            Costo.Location = new Point(273, 112);
            Costo.Name = "Costo";
            Costo.Size = new Size(51, 15);
            Costo.TabIndex = 29;
            Costo.Text = "Apellido";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = SystemColors.ButtonHighlight;
            Nombre.Location = new Point(275, 43);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 28;
            Nombre.Text = "Nombre";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(275, 310);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(250, 23);
            txtMail.TabIndex = 27;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(333, 367);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 51);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(275, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 22;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(275, 130);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 23);
            txtApellido.TabIndex = 33;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(275, 194);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(250, 23);
            txtNombreUsuario.TabIndex = 34;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(275, 254);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(250, 23);
            txtContraseña.TabIndex = 35;
            // 
            // frmUsuario_agregar
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
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Name = "frmUsuario_agregar";
            Text = "frmUsuario_agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Contraseña;
        private Label Mail;
        private Label UserName;
        private Label Costo;
        private Label Nombre;
        private TextBox txtMail;
        private NumericUpDown numStock;
        private NumericUpDown numPrecioVenta;
        private NumericUpDown numCosto;
        private Button btnAgregar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
    }
}