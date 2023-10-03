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
    public partial class frmUsuario_agregar : Form
    {
        public frmUsuario_agregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario._Nombre = txtNombre.ToString();
            usuario._Apellido = txtApellido.ToString();
            usuario._NombreUsuario = txtNombreUsuario.ToString();
            usuario._Contraseña = Contraseña.ToString();
            usuario._Mail = txtMail.ToString();
            Context.AgregarUsuario(usuario);
            MessageBox.Show("Usuario registrado");
        }
    }
}
