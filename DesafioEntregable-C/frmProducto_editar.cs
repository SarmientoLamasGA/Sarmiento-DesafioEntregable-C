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
    public partial class frmProducto_editar : Form
    {
        private Producto _producto;

        public frmProducto_editar()
        {
            InitializeComponent();
            _producto._Descripciones = txtDescripciones.Text;
            _producto._Costo = numCosto.Value;
            _producto._PrecioVenta = numPrecioVenta.Value;
            _producto._Stock = (int)numStock.Value;
            _producto._IdUsuario = int.Parse(txtIdUsuario.Text);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            _producto._Descripciones = txtDescripciones.Text;
            _producto._Costo = numCosto.Value;
            _producto._PrecioVenta = numPrecioVenta.Value;
            _producto._Stock = (int)numStock.Value;
            _producto._IdUsuario = int.Parse(txtIdUsuario.Text);
            Context.AgregarProducto(_producto);
            MessageBox.Show("Producto agregado");
        }
    }
}
