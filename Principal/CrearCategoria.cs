using System;
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
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = categorias;

            // Personaliza los encabezados (si las propiedades son 'codigo' y 'nombre')
            dataGridView1.Columns["codigo_categoria"].HeaderText = "Código";
            dataGridView1.Columns["nombre_categoria"].HeaderText = "Nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaController controller = new CategoriaController();

            if (!int.TryParse(tbCodigo.Text, out int codigo))
            {
                MessageBox.Show("El código debe ser un número entero.");
                return;
            }

            string nombre = tbNombre.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            string resultado = controller.GuardarCategoria(codigo, nombre);
            MessageBox.Show(resultado);

            tbCodigo.Clear();
            tbNombre.Clear();

            CargarCategoria();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo))
            {
                MessageBox.Show("Selecciona primero una fila o ingresa un código válido.");
                return;
            }

            string nuevoNombre = tbNombre.Text;

            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            try
            {
                CategoriaController controller = new CategoriaController();
                string resultado = controller.ActualizarCategoria(codigo, nuevoNombre);
                MessageBox.Show(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar la categoría: {ex.Message}");
            }

            tbCodigo.Clear();
            tbNombre.Clear();
            CargarCategoria();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo))
            {
                MessageBox.Show("Selecciona primero una fila o ingresa un código válido.");
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro de eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    CategoriaController controller = new CategoriaController();
                    string resultado = controller.EliminarCategoria(codigo);
                    MessageBox.Show(resultado);

                    tbCodigo.Clear();
                    tbNombre.Clear();
                    CargarCategoria();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar la categoría: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cuando el usuario hace clic en una fila, cargamos los datos en los TextBox
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["codigo_categoria"].Value != null)
            {
                tbCodigo.Text = dataGridView1.Rows[e.RowIndex].Cells["codigo_categoria"].Value.ToString();
                tbNombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre_categoria"].Value.ToString();
            }
        }
    }
}
