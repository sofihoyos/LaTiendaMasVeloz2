using MySql.Data.MySqlClient;
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
    public partial class IniciarSesiónForm : Form
    {
        public IniciarSesiónForm()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (usuario == "" || contraseña == "")
            {
                MessageBox.Show("Por favor ingresa usuario y contraseña.");
                return;
            }

            string conexion = "Database=laTiendaMasVeloz; Datasource=localhost; User Id=root; Password=Andrea_12345";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("✅ Conexión establecida correctamente");

                    string query = @"SELECT c.usuario, c.contraseña, p.tipo_persona 
                             FROM credenciales c
                             INNER JOIN persona p ON c.fkId_persona = p.id_persona
                             WHERE c.usuario = @usuario AND c.contraseña = @contraseña";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string rol = reader.GetString("tipo_persona");

                                if (rol.ToLower() == "admin")
                                {
                                    MessageBox.Show("Bienvenido, administrador.");
                                    new MenuCrudAdmin().Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("No tienes permisos para ingresar. Contacta al administrador.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
        }
    }
}
