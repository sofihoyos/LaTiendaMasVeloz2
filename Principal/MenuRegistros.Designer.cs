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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRegistros));
            btnRegCli = new Button();
            btnRegProd = new Button();
            btnRegCat = new Button();
            btnRegFac = new Button();
            btnRegEmp = new Button();
            title = new Label();
            btRegresar = new Button();
            SuspendLayout();
            // 
            // btnRegCli
            // 
            btnRegCli.Location = new Point(62, 129);
            btnRegCli.Name = "btnRegCli";
            btnRegCli.Size = new Size(125, 63);
            btnRegCli.TabIndex = 0;
            btnRegCli.Text = "Cliente";
            btnRegCli.UseVisualStyleBackColor = true;
            btnRegCli.Click += btnRegCli_Click;
            // 
            // btnRegProd
            // 
            btnRegProd.Location = new Point(290, 129);
            btnRegProd.Name = "btnRegProd";
            btnRegProd.Size = new Size(125, 63);
            btnRegProd.TabIndex = 1;
            btnRegProd.Text = "Producto";
            btnRegProd.UseVisualStyleBackColor = true;
            btnRegProd.Click += btnRegProd_Click;
            // 
            // btnRegCat
            // 
            btnRegCat.Location = new Point(511, 129);
            btnRegCat.Name = "btnRegCat";
            btnRegCat.Size = new Size(125, 63);
            btnRegCat.TabIndex = 2;
            btnRegCat.Text = " Categoria";
            btnRegCat.UseVisualStyleBackColor = true;
            btnRegCat.Click += btnRegCat_Click;
            // 
            // btnRegFac
            // 
            btnRegFac.Location = new Point(191, 237);
            btnRegFac.Name = "btnRegFac";
            btnRegFac.Size = new Size(125, 63);
            btnRegFac.TabIndex = 3;
            btnRegFac.Text = " Factura";
            btnRegFac.UseVisualStyleBackColor = true;
            btnRegFac.Click += btnRegFac_Click;
            // 
            // btnRegEmp
            // 
            btnRegEmp.Location = new Point(398, 237);
            btnRegEmp.Name = "btnRegEmp";
            btnRegEmp.Size = new Size(125, 63);
            btnRegEmp.TabIndex = 4;
            btnRegEmp.Text = " Empleado";
            btnRegEmp.UseVisualStyleBackColor = true;
            btnRegEmp.Click += btnRegEmp_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            title.Location = new Point(288, 49);
            title.Name = "title";
            title.Size = new Size(127, 37);
            title.TabIndex = 5;
            title.Text = "Registro";
            // 
            // btRegresar
            // 
            btRegresar.Location = new Point(290, 356);
            btRegresar.Name = "btRegresar";
            btRegresar.Size = new Size(112, 32);
            btRegresar.TabIndex = 8;
            btRegresar.Text = "Regresar";
            btRegresar.UseVisualStyleBackColor = true;
            // 
            // MenuRegistros
            // 
            ClientSize = new Size(697, 428);
            Controls.Add(btRegresar);
            Controls.Add(title);
            Controls.Add(btnRegEmp);
            Controls.Add(btnRegFac);
            Controls.Add(btnRegCat);
            Controls.Add(btnRegProd);
            Controls.Add(btnRegCli);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuRegistros";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnRegCli;
        private Button btnRegProd;
        private Button btnRegCat;
        private Button btnRegFac;
        private Button btnRegEmp;
        private Label title;
        private Button btRegresar;
    }
}