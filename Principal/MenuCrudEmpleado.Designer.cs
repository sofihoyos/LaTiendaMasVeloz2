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
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            // button2
            // 
            button2.Location = new Point(143, 245);
            button2.Name = "button2";
            button2.Size = new Size(173, 34);
            button2.TabIndex = 5;
            button2.Text = "Cliente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(437, 245);
            button5.Name = "button5";
            button5.Size = new Size(173, 34);
            button5.TabIndex = 8;
            button5.Text = "Factura";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(315, 451);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 9;
            button6.Text = "Regresar";
            button6.UseVisualStyleBackColor = true;
            // 
            // MenuCrudEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 521);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "MenuCrudEmpleado";
            Text = "MenuCrudEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button5;
        private Button button6;
    }
}