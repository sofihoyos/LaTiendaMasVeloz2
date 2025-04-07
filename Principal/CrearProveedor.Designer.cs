namespace Principal
{
    partial class CrearProveedor
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
            label1 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            btnRegresar = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Cédula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 52);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 1;
            label1.Text = "Tabla Proveedor";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(165, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(163, 23);
            textBox4.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 194);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 15;
            label5.Text = "Correo:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(496, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 188);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 13;
            label4.Text = "Teléfono:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(496, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(390, 139);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 11;
            label3.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 134);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 9;
            label2.Text = "Cédula / NIT:";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(615, 481);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 21;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(307, 481);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 20;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(186, 481);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(69, 481);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Cédula, Nombre, Teléfono, Correo });
            dataGridView1.Location = new Point(99, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 150);
            dataGridView1.TabIndex = 22;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Cédula
            // 
            Cédula.HeaderText = "Cédula/nit";
            Cédula.Name = "Cédula";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Teléfono
            // 
            Teléfono.HeaderText = "Teléfono";
            Teléfono.Name = "Teléfono";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // CrearProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 521);
            Controls.Add(dataGridView1);
            Controls.Add(btnRegresar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearProveedor";
            Text = "CrearProveedor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Button btnRegresar;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cédula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Teléfono;
        private DataGridViewTextBoxColumn Correo;
    }
}