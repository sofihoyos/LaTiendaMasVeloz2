namespace Principal
{
    partial class RegistrarDetalleFactura
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
            titleRegistrarEmpleado = new Label();
            SuspendLayout();
            // 
            // titleRegistrarEmpleado
            // 
            titleRegistrarEmpleado.AutoSize = true;
            titleRegistrarEmpleado.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleRegistrarEmpleado.Location = new Point(248, 51);
            titleRegistrarEmpleado.Name = "titleRegistrarEmpleado";
            titleRegistrarEmpleado.Size = new Size(249, 37);
            titleRegistrarEmpleado.TabIndex = 6;
            titleRegistrarEmpleado.Text = "Registrar Factura";
            // 
            // RegistrarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titleRegistrarEmpleado);
            Name = "RegistrarFactura";
            Text = "RegistrarFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleRegistrarEmpleado;
    }
}