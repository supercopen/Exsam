﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demoexzamin
{
    public partial class Zakazchik : Form
    {
        public Zakazchik()
        {
            InitializeComponent();
        }

        private void Zakazchik_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form lp = new logpas();
            lp.Show();
        }
    }
}
