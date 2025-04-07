namespace Principal
{
    partial class MenuCruds
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
            btnCategoria = new Button();
            btnCliente = new Button();
            btnProveedor = new Button();
            btnEmpleado = new Button();
            btnFactura = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 76);
            label1.Name = "label1";
            label1.Size = new Size(107, 37);
            label1.TabIndex = 2;
            label1.Text = "CRUDS";
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(130, 193);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(173, 34);
            btnCategoria.TabIndex = 3;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(404, 193);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(173, 34);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(130, 291);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(173, 34);
            btnProveedor.TabIndex = 5;
            btnProveedor.Text = "Proveedor";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(404, 291);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(173, 34);
            btnEmpleado.TabIndex = 6;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(268, 365);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(173, 34);
            btnFactura.TabIndex = 7;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(303, 475);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(112, 34);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // MenuCruds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 521);
            Controls.Add(btnRegresar);
            Controls.Add(btnFactura);
            Controls.Add(btnEmpleado);
            Controls.Add(btnProveedor);
            Controls.Add(btnCliente);
            Controls.Add(btnCategoria);
            Controls.Add(label1);
            Name = "MenuCruds";
            Text = "MenuCruds";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCategoria;
        private Button btnCliente;
        private Button btnProveedor;
        private Button btnEmpleado;
        private Button btnFactura;
        private Button btnRegresar;
    }
}