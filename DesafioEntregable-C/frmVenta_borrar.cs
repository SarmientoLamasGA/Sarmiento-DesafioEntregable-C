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
    public partial class frmVenta_borrar : Form
    {
        private Venta _venta;
        public frmVenta_borrar()
        {
            InitializeComponent();
            _venta._Comentarios = txtComentarios.Text.ToString();
            _venta._IdUsuario = Convert.ToInt32(numIdUsuario.Value);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Context.QuitarVenta(_venta);
            MessageBox.Show("Venta borrada");
        }
    }
}