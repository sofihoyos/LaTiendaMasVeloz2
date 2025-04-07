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
            btnCategoria = new Button();
            btnCliente = new Button();
            btnProveedor = new Button();
            btnEmpleado = new Button();
            btnFactura = new Button();
            btnRegresar = new Button();
         
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 76);
            label1.Name = "label1";
            label1.Size = new Size(112, 37);
            label1.TabIndex = 2;
            label1.Text = "ADMIN";
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(130, 193);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(173, 34);
            btnCategoria.TabIndex = 3;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
          
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(404, 193);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(173, 34);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
   
            // 
            // btnProveedor
            // 
            btnProveedor.Location = new Point(130, 291);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(173, 34);
            btnProveedor.TabIndex = 5;
            btnProveedor.Text = "Proveedor";
            btnProveedor.UseVisualStyleBackColor = true;
   
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(404, 291);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(173, 34);
            btnEmpleado.TabIndex = 6;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
           
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(268, 365);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(173, 34);
            btnFactura.TabIndex = 7;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = true;
    
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(303, 475);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(112, 34);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
      
            // 
            // MenuCrudAdmin
            // 

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