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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btRegresar = new Button();
            button2 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(254, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Ingresa tu usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "Ingresa tu contraseña";
            // 
            // btRegresar
            // 
            btRegresar.Location = new Point(201, 311);
            btRegresar.Name = "btRegresar";
            btRegresar.Size = new Size(142, 41);
            btRegresar.TabIndex = 7;
            btRegresar.Text = "Regresar";
            btRegresar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(460, 311);
            button2.Name = "button2";
            button2.Size = new Size(142, 41);
            button2.TabIndex = 8;
            button2.Text = "Iniciar Sesión";
            button2.UseVisualStyleBackColor = true;
            // 
            // IniciarSesiónForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btRegresar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(title);
            Name = "IniciarSesiónForm";
            Text = "IniciarSesiónForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btRegresar;
        private Button button2;
    }
}