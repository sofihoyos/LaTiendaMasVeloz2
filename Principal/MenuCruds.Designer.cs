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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            // button1
            // 
            button1.Location = new Point(130, 193);
            button1.Name = "button1";
            button1.Size = new Size(173, 34);
            button1.TabIndex = 3;
            button1.Text = "Categoria";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(404, 193);
            button2.Name = "button2";
            button2.Size = new Size(173, 34);
            button2.TabIndex = 4;
            button2.Text = "Cliente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(130, 291);
            button3.Name = "button3";
            button3.Size = new Size(173, 34);
            button3.TabIndex = 5;
            button3.Text = "Proveedor";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(404, 291);
            button4.Name = "button4";
            button4.Size = new Size(173, 34);
            button4.TabIndex = 6;
            button4.Text = "Empleado";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(268, 365);
            button5.Name = "button5";
            button5.Size = new Size(173, 34);
            button5.TabIndex = 7;
            button5.Text = "Factura";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(303, 475);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 8;
            button6.Text = "Regresar";
            button6.UseVisualStyleBackColor = true;
            // 
            // MenuCruds
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 521);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MenuCruds";
            Text = "MenuCruds";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}