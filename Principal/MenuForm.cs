﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            MenuInicio fr = new MenuInicio();
            fr.ShowDialog();
        }
    }
}
