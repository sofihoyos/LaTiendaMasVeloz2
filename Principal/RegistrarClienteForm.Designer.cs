﻿namespace Principal
{
    partial class RegistrarClienteForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btRegistrarme = new Button();
            btRegresar = new Button();
            SuspendLayout();
            // 
            // titleRegistrarEmpleado
            // 
            titleRegistrarEmpleado.AutoSize = true;
            titleRegistrarEmpleado.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleRegistrarEmpleado.Location = new Point(260, 59);
            titleRegistrarEmpleado.Name = "titleRegistrarEmpleado";
            titleRegistrarEmpleado.Size = new Size(238, 37);
            titleRegistrarEmpleado.TabIndex = 6;
            titleRegistrarEmpleado.Text = "Registrar Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "Ingresa tu cédula";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 23);
            textBox2.TabIndex = 8;
            textBox2.Text = "Ingrese el nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 270);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(351, 23);
            textBox3.TabIndex = 9;
            textBox3.Text = "Ingrese el teléfono";
            // 
            // btRegistrarme
            // 
            btRegistrarme.Location = new Point(455, 340);
            btRegistrarme.Name = "btRegistrarme";
            btRegistrarme.Size = new Size(142, 41);
            btRegistrarme.TabIndex = 10;
            btRegistrarme.Text = "Registrar";
            btRegistrarme.UseVisualStyleBackColor = true;
            // 
            // btRegresar
            // 
            btRegresar.Location = new Point(182, 340);
            btRegresar.Name = "btRegresar";
            btRegresar.Size = new Size(142, 41);
            btRegresar.TabIndex = 11;
            btRegresar.Text = "Regresar";
            btRegresar.UseVisualStyleBackColor = true;
            // 
            // RegistrarClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btRegresar);
            Controls.Add(btRegistrarme);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(titleRegistrarEmpleado);
            Name = "RegistrarClienteForm";
            Text = "RegistrarClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleRegistrarEmpleado;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btRegistrarme;
        private Button btRegresar;
    }
}