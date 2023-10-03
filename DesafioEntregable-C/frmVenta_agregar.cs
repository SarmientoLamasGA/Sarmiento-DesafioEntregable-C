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
    public partial class frmVenta_agregar : Form
    {
        public frmVenta_agregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta._Comentarios = txtComentarios.Text.ToString();
            venta._IdUsuario = Convert.ToInt32(numIdUsuario.Value);
            Context.AgregarVenta(venta);
            MessageBox.Show("Nueva venta");
        }
    }
}
