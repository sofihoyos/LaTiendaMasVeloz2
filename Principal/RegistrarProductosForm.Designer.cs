namespace Principal
{
    partial class RegistrarProductosForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            btRegresar = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // titleRegistrarEmpleado
            // 
            titleRegistrarEmpleado.AutoSize = true;
            titleRegistrarEmpleado.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleRegistrarEmpleado.Location = new Point(254, 24);
            titleRegistrarEmpleado.Name = "titleRegistrarEmpleado";
            titleRegistrarEmpleado.Size = new Size(280, 37);
            titleRegistrarEmpleado.TabIndex = 7;
            titleRegistrarEmpleado.Text = "Registrar Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 84);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 8;
            label1.Text = "Información Básica";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 9;
            textBox1.Text = "Ingresa el código";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 23);
            textBox2.TabIndex = 10;
            textBox2.Text = "Ingresa el nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(448, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 23);
            textBox3.TabIndex = 11;
            textBox3.Text = "Ingresa la descripción";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(451, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 23);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Selecciona la categoria";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btRegresar
            // 
            btRegresar.Location = new Point(429, 293);
            btRegresar.Name = "btRegresar";
            btRegresar.Size = new Size(142, 41);
            btRegresar.TabIndex = 26;
            btRegresar.Text = "Continuar";
            btRegresar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(193, 293);
            button1.Name = "button1";
            button1.Size = new Size(142, 41);
            button1.TabIndex = 28;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 23);
            textBox4.TabIndex = 29;
            textBox4.Text = "Ingresa el precio";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(448, 181);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(231, 23);
            textBox5.TabIndex = 30;
            textBox5.Text = "Ingresa la cantidad disponible";
            // 
            // RegistrarProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(btRegresar);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(titleRegistrarEmpleado);
            Name = "RegistrarProductosForm";
            Text = "RegistrarProductosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleRegistrarEmpleado;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button btRegresar;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}