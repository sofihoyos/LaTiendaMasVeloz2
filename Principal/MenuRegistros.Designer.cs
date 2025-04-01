namespace Principal
{
    partial class MenuRegistros
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
            btnRegCli = new Button();
            btnRegProd = new Button();
            btnRegCat = new Button();
            btnRegFac = new Button();
            btnRegEmp = new Button();
            SuspendLayout();
            // 
            // btnRegCli
            // 
            btnRegCli.Location = new Point(152, 63);
            btnRegCli.Name = "btnRegCli";
            btnRegCli.Size = new Size(125, 63);
            btnRegCli.TabIndex = 0;
            btnRegCli.Text = "Registrar Cliente";
            btnRegCli.UseVisualStyleBackColor = true;
            btnRegCli.Click += btnRegCli_Click;
            // 
            // btnRegProd
            // 
            btnRegProd.Location = new Point(421, 63);
            btnRegProd.Name = "btnRegProd";
            btnRegProd.Size = new Size(125, 63);
            btnRegProd.TabIndex = 1;
            btnRegProd.Text = "Registrar Producto";
            btnRegProd.UseVisualStyleBackColor = true;
            btnRegProd.Click += btnRegProd_Click;
            // 
            // btnRegCat
            // 
            btnRegCat.Location = new Point(421, 202);
            btnRegCat.Name = "btnRegCat";
            btnRegCat.Size = new Size(125, 63);
            btnRegCat.TabIndex = 2;
            btnRegCat.Text = "Registrar Categoria";
            btnRegCat.UseVisualStyleBackColor = true;
            btnRegCat.Click += btnRegCat_Click;
            // 
            // btnRegFac
            // 
            btnRegFac.Location = new Point(152, 202);
            btnRegFac.Name = "btnRegFac";
            btnRegFac.Size = new Size(125, 63);
            btnRegFac.TabIndex = 3;
            btnRegFac.Text = "Registrar Factura";
            btnRegFac.UseVisualStyleBackColor = true;
            btnRegFac.Click += btnRegFac_Click;
            // 
            // btnRegEmp
            // 
            btnRegEmp.Location = new Point(283, 324);
            btnRegEmp.Name = "btnRegEmp";
            btnRegEmp.Size = new Size(125, 63);
            btnRegEmp.TabIndex = 4;
            btnRegEmp.Text = "Registrar Empleado";
            btnRegEmp.UseVisualStyleBackColor = true;
            btnRegEmp.Click += btnRegEmp_Click;
            // 
            // MenuRegistros
            // 
            ClientSize = new Size(697, 428);
            Controls.Add(btnRegEmp);
            Controls.Add(btnRegFac);
            Controls.Add(btnRegCat);
            Controls.Add(btnRegProd);
            Controls.Add(btnRegCli);
            Name = "MenuRegistros";
            ResumeLayout(false);
        }
        #endregion

        private Button btnRegCli;
        private Button btnRegProd;
        private Button btnRegCat;
        private Button btnRegFac;
        private Button btnRegEmp;
    }
}