using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class MenuCrudAdmin : Form
    {
        public MenuCrudAdmin()
        {
            InitializeComponent();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            CrearProveedor fr = new CrearProveedor();
            fr.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CrearCliente fr = new CrearCliente();
            fr.ShowDialog();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            CrearEmpleado fr = new CrearEmpleado();
            fr.ShowDialog();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            CrearCategoria fr = new CrearCategoria();
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
