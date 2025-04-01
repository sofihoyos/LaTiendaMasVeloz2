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
    public partial class MenuRegistros : Form
    {
        public MenuRegistros()
        {
            InitializeComponent();
        }

        private void btnRegCli_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrar Cliente");
            RegistroPersona fr = new RegistroPersona();
            fr.ShowDialog();
        }

        private void btnRegProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrar Producto");
            RegistrarProductosForm fr = new RegistrarProductosForm();
            fr.ShowDialog();
        }

        private void btnRegFac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrar Factura");
        }

        private void btnRegCat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrar Categoria");
            RegistrarCategoriaForm fr = new RegistrarCategoriaForm();
            fr.ShowDialog();
        }

        private void btnRegEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrar Empleado");
            RegistroPersona fr = new RegistroPersona();
            fr.ShowDialog();
        }
    }
}
