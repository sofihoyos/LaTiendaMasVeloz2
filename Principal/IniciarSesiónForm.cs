﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class IniciarSesiónForm : Form
    {
        public IniciarSesiónForm()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            MenuCrudAdmin fr = new MenuCrudAdmin();
            fr.ShowDialog();
        }
    }
}
