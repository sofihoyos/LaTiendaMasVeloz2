namespace Principal
{
    partial class MenuCrudAdmin
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
            btnProveedor = new Button();
            btnCliente = new Button();
            btnEmpleado = new Button();
            btnCategoria = new Button();
            btnFactura = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 31);
            label1.Name = "label1";
            label1.Size = new Size(247, 37);
            label1.TabIndex = 4;
            label1.Text = "ADMINISTRADOR";
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(83, 120);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(173, 34);
            btnProveedor.TabIndex = 6;
            btnProveedor.Text = "Proveedor";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(504, 111);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(173, 34);
            btnCliente.TabIndex = 7;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(83, 213);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(173, 34);
            btnEmpleado.TabIndex = 8;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(504, 213);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(173, 34);
            btnCategoria.TabIndex = 9;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(302, 282);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(173, 34);
            btnFactura.TabIndex = 10;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(331, 394);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(112, 34);
            btnRegresar.TabIndex = 11;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // MenuCrudAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnFactura);
            Controls.Add(btnCategoria);
            Controls.Add(btnEmpleado);
            Controls.Add(btnCliente);
            Controls.Add(btnProveedor);
            Controls.Add(label1);
            Name = "MenuCrudAdmin";
            Text = "MenuCrudAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnProveedor;
        private Button btnCliente;
        private Button btnEmpleado;
        private Button btnCategoria;
        private Button btnFactura;
        private Button btnRegresar;
    }
}