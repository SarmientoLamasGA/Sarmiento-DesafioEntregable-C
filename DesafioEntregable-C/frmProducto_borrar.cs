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
    public partial class frmProducto_borrar : Form
    {
        private Producto _producto;
        public frmProducto_borrar()
        {
            InitializeComponent();
            this.txtDescripciones.Text = _producto._IdUsuario.ToString();
            this.numCosto.Value = _producto._Costo;
            this.numPrecioVenta.Value = _producto._PrecioVenta;
            this.numStock.Value = _producto._Stock;
            this.txtIdUsuario.Text = _producto._IdUsuario.ToString();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Context.QuitarProducto(_producto);
            MessageBox.Show("Producto Eliminado");
        }
    }
}
