using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioEntregable_C
{
    public partial class frmUsuario_Editar : Form
    {
        private Usuario _usuario;
        public frmUsuario_Editar()
        {
            InitializeComponent();
            _usuario._Nombre = txtNombre.ToString();
            _usuario._Apellido = txtApellido.ToString();
            _usuario._NombreUsuario = txtNombreUsuario.ToString();
            _usuario._Contraseña = Contraseña.ToString();
            _usuario._Mail = txtMail.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _usuario._Nombre = txtNombre.ToString();
            _usuario._Apellido = txtApellido.ToString();
            _usuario._NombreUsuario = txtNombreUsuario.ToString();
            _usuario._Contraseña = Contraseña.ToString();
            _usuario._Mail = txtMail.ToString();
            Context.AgregarUsuario(_usuario);
            MessageBox.Show("Usuario registrado");
        }
    }
}
