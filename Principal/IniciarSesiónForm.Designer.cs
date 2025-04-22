namespace Principal
{
    partial class IniciarSesiónForm
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
            title = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnRegresar = new Button();
            btnIniciarSesion = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            title.Location = new Point(300, 70);
            title.Name = "title";
            title.Size = new Size(179, 37);
            title.TabIndex = 4;
            title.Text = "Inicio Sesión";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(254, 155);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(272, 23);
            txtUsuario.TabIndex = 5;
            txtUsuario.Text = "Ingresa tu usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(254, 224);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(272, 23);
            txtContraseña.TabIndex = 6;
            txtContraseña.Text = "Ingresa tu contraseña";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(201, 311);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(142, 41);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(460, 311);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(142, 41);
            btnIniciarSesion.TabIndex = 8;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click_1;
            // 
            // IniciarSesiónForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciarSesion);
            Controls.Add(btnRegresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(title);
            Name = "IniciarSesiónForm";
            Text = "IniciarSesiónForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnRegresar;
        private Button btnIniciarSesion;
    }
}