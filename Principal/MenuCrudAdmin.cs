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
    public partial class MenuCruds : Form
    {
        public MenuCrudAdmin()
        {
            InitializeComponent();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            CrearCategoria fr = new CrearCategoria();
            fr.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CrearCliente fr = new CrearCliente();
            fr.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            CrearProveedor fr = new CrearProveedor();
            fr.ShowDialog();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            CrearEmpleado fr = new CrearEmpleado();
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

        private void InitializeComponent()
        {
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 77);
            label1.Name = "label1";
            label1.Size = new Size(112, 37);
            label1.TabIndex = 4;
            label1.Text = "ADMIN";
            // 
            // button2
            // 
            button2.Location = new Point(442, 243);
            button2.Name = "button2";
            button2.Size = new Size(173, 34);
            button2.TabIndex = 6;
            button2.Text = "Categoria";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(104, 243);
            button1.Name = "button1";
            button1.Size = new Size(173, 34);
            button1.TabIndex = 7;
            button1.Text = "Cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(451, 168);
            button3.Name = "button3";
            button3.Size = new Size(173, 34);
            button3.TabIndex = 8;
            button3.Text = "Empleado";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(112, 168);
            button4.Name = "button4";
            button4.Size = new Size(173, 34);
            button4.TabIndex = 9;
            button4.Text = "Proveedor";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(287, 323);
            button5.Name = "button5";
            button5.Size = new Size(173, 34);
            button5.TabIndex = 10;
            button5.Text = "Factura";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(315, 444);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 11;
            button6.Text = "Regresar";
            button6.UseVisualStyleBackColor = true;
            // 
            // MenuCruds
            // 
            ClientSize = new Size(739, 521);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "MenuCruds";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
