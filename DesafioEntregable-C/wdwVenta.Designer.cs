namespace DesafioEntregable_C
{
    partial class WdwVenta
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
            dataGridView1 = new DataGridView();
            btnAgregarVenta = new Button();
            Id = new DataGridViewTextBoxColumn();
            Comentarios = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Comentarios, IdUsuario, Editar, Eliminar });
            dataGridView1.Location = new Point(12, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 353);
            dataGridView1.TabIndex = 0;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(620, 12);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(168, 67);
            btnAgregarVenta.TabIndex = 1;
            btnAgregarVenta.Text = "Agregar Venta";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Comentarios
            // 
            Comentarios.DataPropertyName = "Comentarios";
            Comentarios.HeaderText = "Comentarios";
            Comentarios.Name = "Comentarios";
            Comentarios.ReadOnly = true;
            // 
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "ID del Usuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.DataPropertyName = "btnEditar";
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.DataPropertyName = "btnEliminar";
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // WdwVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarVenta);
            Controls.Add(dataGridView1);
            Name = "WdwVenta";
            Text = "wdwVentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregarVenta;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Comentarios;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}