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
    public partial class RegistrarCategoriaForm : Form
    {
        public RegistrarCategoriaForm()
        {
            InitializeComponent();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            MenuRegistros fr = new MenuRegistros();
            fr.ShowDialog();
        }
    }
}
