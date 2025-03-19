namespace Principal
{
    partial class RegistrarProveedorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleRegistrarEmpleado = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btRegistrarme = new Button();
            btRegresar = new Button();
            SuspendLayout();
            // 
            // titleRegistrarEmpleado
            // 
            titleRegistrarEmpleado.AutoSize = true;
            titleRegistrarEmpleado.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleRegistrarEmpleado.Location = new Point(264, 37);
            titleRegistrarEmpleado.Name = "titleRegistrarEmpleado";
            titleRegistrarEmpleado.Size = new Size(284, 37);
            titleRegistrarEmpleado.TabIndex = 7;
            titleRegistrarEmpleado.Text = "Registrar Proveedor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "Ingresa tu nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 23);
            textBox2.TabIndex = 9;
            textBox2.Text = "Ingresa tu NIT";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(239, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(334, 23);
            textBox3.TabIndex = 10;
            textBox3.Text = "Ingresa tu correo electrónico";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(239, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(334, 23);
            textBox4.TabIndex = 11;
            textBox4.Text = "Ingresa tu teléfono";
            // 
            // btRegistrarme
            // 
            btRegistrarme.Location = new Point(479, 364);
            btRegistrarme.Name = "btRegistrarme";
            btRegistrarme.Size = new Size(142, 41);
            btRegistrarme.TabIndex = 12;
            btRegistrarme.Text = "Registrar";
            btRegistrarme.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            btRegresar.Location = new Point(188, 364);
            btRegresar.Name = "btRegresar";
            btRegresar.Size = new Size(142, 41);
            btRegresar.TabIndex = 13;
            btRegresar.Text = "Regresar";
            btRegresar.UseVisualStyleBackColor = true;
            // 
            // RegistrarProveedorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btRegresar);
            Controls.Add(btRegistrarme);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(titleRegistrarEmpleado);
            Name = "RegistrarProveedorForm";
            Text = "RegistrarProveedorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleRegistrarEmpleado;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btRegistrarme;
        private Button btRegresar;
    }
}