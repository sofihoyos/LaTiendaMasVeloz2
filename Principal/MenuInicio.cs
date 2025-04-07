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
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            IniciarSesiónForm fr = new IniciarSesiónForm();
            fr.ShowDialog();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            MenuCrudEmpleado fr = new MenuCrudEmpleado();
            fr.ShowDialog();
        }
    }
}
