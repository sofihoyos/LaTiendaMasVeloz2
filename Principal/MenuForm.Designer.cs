namespace Principal
{
    partial class MenuForm
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
            title = new Label();
            btContinuar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 57);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            title.Location = new Point(273, 222);
            title.Name = "title";
            title.Size = new Size(280, 37);
            title.TabIndex = 3;
            title.Text = "La tienda más veloz";
            // 
            // btContinuar
            // 
            btContinuar.Location = new Point(324, 303);
            btContinuar.Name = "btContinuar";
            btContinuar.Size = new Size(150, 55);
            btContinuar.TabIndex = 4;
            btContinuar.Text = "Continuar";
            btContinuar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoLatienda;
            pictureBox1.Location = new Point(273, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 446);
            Controls.Add(title);
            Controls.Add(pictureBox1);
            Controls.Add(btContinuar);
            Controls.Add(label1);
            Name = "MenuForm";
            Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label title;
        private Button btContinuar;
        private PictureBox pictureBox1;
    }
}