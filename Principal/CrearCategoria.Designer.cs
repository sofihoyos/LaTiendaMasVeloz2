namespace Principal
{
    partial class CrearCategoria
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
            tbNombre = new TextBox();
            label3 = new Label();
            tbCodigo = new TextBox();
            label2 = new Label();
            btnRegresar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            lbResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 50);
            label1.Name = "label1";
            label1.Size = new Size(219, 37);
            label1.TabIndex = 1;
            label1.Text = "Tabla Categoria";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(495, 165);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(163, 23);
            tbNombre.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(389, 171);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 7;
            label3.Text = "Nombre:";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(164, 165);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(163, 23);
            tbCodigo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 166);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 5;
            label2.Text = "Código:";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(612, 443);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 18;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(304, 443);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(183, 443);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(66, 443);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Nombre });
            dataGridView1.Location = new Point(241, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(243, 150);
            dataGridView1.TabIndex = 14;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(573, 263);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(38, 15);
            lbResultado.TabIndex = 19;
            lbResultado.Text = "label4";
            // 
            // CrearCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 521);
            Controls.Add(lbResultado);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(tbCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearCategoria";
            Text = "CrearCategoria";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private Label label3;
        private TextBox tbCodigo;
        private Label label2;
        private Button btnRegresar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nombre;
        private Label lbResultado;
    }
}