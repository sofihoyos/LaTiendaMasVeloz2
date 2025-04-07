namespace Principal
{
    partial class MenuCrudEmpleado
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
            btnCliente = new Button();
            btnFactura = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 110);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 3;
            label1.Text = "EMPLEADOS";
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(143, 245);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(173, 34);
            btnCliente.TabIndex = 5;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(437, 245);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(173, 34);
            btnFactura.TabIndex = 8;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(315, 451);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(112, 34);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // MenuCrudEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 521);
            Controls.Add(btnRegresar);
            Controls.Add(btnFactura);
            Controls.Add(btnCliente);
            Controls.Add(label1);
            Name = "MenuCrudEmpleado";
            Text = "MenuCrudEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCliente;
        private Button btnFactura;
        private Button btnRegresar;
    }
}