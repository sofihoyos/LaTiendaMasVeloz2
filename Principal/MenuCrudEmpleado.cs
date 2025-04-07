using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Principal
{
    public partial class MenuCrudEmpleado : Form
    {
        public MenuCrudEmpleado()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CrearCliente fr = new CrearCliente();
            fr.ShowDialog();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            CrearFactura fr = new CrearFactura();
            fr.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
