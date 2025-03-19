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
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label3 = new Label();
            btRegresar = new Button();
            comboBox2 = new ComboBox();
            button1 = new Button();
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
            comboBox1.Location = new Point(285, 278);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 23);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Selecciona la categoria";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(448, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 23);
            textBox4.TabIndex = 13;
            textBox4.Text = "Ingresa la marca";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(130, 230);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(231, 23);
            textBox5.TabIndex = 14;
            textBox5.Text = "Ingresa el modelo";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(448, 230);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(231, 23);
            textBox6.TabIndex = 15;
            textBox6.Text = "Ingresa el precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 321);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 16;
            label2.Text = "Detalles Técnicos";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(130, 385);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(231, 23);
            textBox7.TabIndex = 17;
            textBox7.Text = "Ingresa el material";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(130, 438);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(231, 23);
            textBox8.TabIndex = 18;
            textBox8.Text = "Ingresa el tamaño o talla";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(448, 385);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(231, 23);
            textBox9.TabIndex = 19;
            textBox9.Text = "Ingresa el color";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(448, 438);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(231, 23);
            textBox10.TabIndex = 20;
            textBox10.Text = "Ingresa la cantidad disponible";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 520);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 21;
            label3.Text = "Detalles del Proveedor";
            // 
            // btRegresar
            // 
            btRegresar.Location = new Point(448, 658);
            btRegresar.Name = "btRegresar";
            btRegresar.Size = new Size(142, 41);
            btRegresar.TabIndex = 26;
            btRegresar.Text = "Continuar";
            btRegresar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(133, 579);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 23);
            comboBox2.TabIndex = 27;
            comboBox2.Text = "Selecciona el proveedor";
            // 
            // button1
            // 
            button1.Location = new Point(203, 658);
            button1.Name = "button1";
            button1.Size = new Size(142, 41);
            button1.TabIndex = 28;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            // 
            // RegistrarProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 749);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(btRegresar);
            Controls.Add(label3);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
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
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label3;
        private Button btRegresar;
        private ComboBox comboBox2;
        private Button button1;
    }
}