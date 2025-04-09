using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Modelo.Entities;

namespace Principal
{
    public partial class CrearCategoria : Form
    {
        public CrearCategoria()
        {
            InitializeComponent();
            CargarCategoria();
        }
        private void CargarCategoria()
        {
            CategoriaController controller = new CategoriaController();
            var categorias = controller.MostrarCategorias();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = categorias;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaController controller = new CategoriaController();

            int codigo;
            if (!int.TryParse(tbCodigo.Text, out codigo))
            {
                MessageBox.Show("El código debe ser un número entero.");
                return;
            }

            string nombre = tbNombre.Text;

            string resultado = controller.GuardarCategoria(codigo, nombre);
            MessageBox.Show(resultado);

            CargarCategoria();
        }
    }
}
