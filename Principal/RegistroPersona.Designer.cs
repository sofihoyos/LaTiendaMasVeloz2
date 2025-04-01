namespace Principal
{
    partial class RegistroPersona
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
            btRegistrarme = new Button();
            btRegresar = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // titleRegistrarEmpleado
            // 
            titleRegistrarEmpleado.AutoSize = true;
            titleRegistrarEmpleado.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleRegistrarEmpleado.Location = new Point(257, 35);
            titleRegistrarEmpleado.Name = "titleRegistrarEmpleado";
            titleRegistrarEmpleado.Size = new Size(278, 37);
            titleRegistrarEmpleado.TabIndex = 5;
            titleRegistrarEmpleado.Text = "Registrar Empleado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "Ingresa tu cédula";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 23);
            textBox2.TabIndex = 7;
            textBox2.Text = "Ingresa el usuario";
            // 
            // btRegistrarme
            // 
            btRegistrarme.Location = new Point(464, 359);
            btRegistrarme.Name = "btRegistrarme";
            btRegistrarme.Size = new Size(142, 41);
            btRegistrarme.TabIndex = 9;
            btRegistrarme.Text = "Registrarme";
            btRegistrarme.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            btRegresar.Location = new Point(192, 359);
            btRegresar.Name = "btRegresar";
            btRegresar.Size = new Size(142, 41);
            btRegresar.TabIndex = 10;
            btRegresar.Text = "Regresar";
            btRegresar.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(228, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(334, 23);
            textBox3.TabIndex = 11;
            textBox3.Text = "Ingresa tu nombre completo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(228, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(334, 23);
            textBox4.TabIndex = 12;
            textBox4.Text = "Ingresa tu contraseña";
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(btRegresar);
            Controls.Add(btRegistrarme);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(titleRegistrarEmpleado);
            Name = "RegistroForm";
            Text = "RegistroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleRegistrarEmpleado;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btRegistrarme;
        private Button btRegresar;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}