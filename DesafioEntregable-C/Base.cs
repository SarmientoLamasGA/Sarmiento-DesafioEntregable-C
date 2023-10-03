namespace DesafioEntregable_C
{
    public partial class wdwBase : Form
    {
        public wdwBase()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            WdwProductos wdwProductos = new WdwProductos();
            wdwProductos.FormClosed += wdwProductos_FormClosed;
            wdwProductos.ShowDialog();
        }

        private void wdwProductos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            WdwUsuarios wdwUsuarios = new WdwUsuarios();
            wdwUsuarios.FormClosed += WdwUsuarios_FormClosed;
            wdwUsuarios.ShowDialog();
        }

        private void WdwUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnProdcutosVendidos_Click(object sender, EventArgs e)
        {

        }
    }
}