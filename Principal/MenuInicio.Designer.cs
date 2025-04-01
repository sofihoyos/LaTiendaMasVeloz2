namespace Principal
{
    partial class MenuInicio
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
            title1 = new Label();
            btIniciarSesion = new Button();
            SuspendLayout();
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            title1.Location = new Point(183, 104);
            title1.Name = "title1";
            title1.Size = new Size(280, 37);
            title1.TabIndex = 4;
            title1.Text = "La tienda más veloz";
            // 
            // btIniciarSesion
            // 
            btIniciarSesion.Location = new Point(268, 214);
            btIniciarSesion.Name = "btIniciarSesion";
            btIniciarSesion.Size = new Size(121, 60);
            btIniciarSesion.TabIndex = 5;
            btIniciarSesion.Text = "Iniciar Sesión";
            btIniciarSesion.UseVisualStyleBackColor = true;
            btIniciarSesion.Click += btIniciarSesion_Click;
            // 
            // MenuInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 381);
            Controls.Add(btIniciarSesion);
            Controls.Add(title1);
            Name = "MenuInicio";
            Text = "MenuInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title1;
        private Button btIniciarSesion;
    }
}