﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaicesDeFunciones
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetCerrados_Click(object sender, EventArgs e)
        {
            Form1 irForm1 = new Form1();
            irForm1.Show();
            this.Hide();
        }

        private void MetAbiertos_Click(object sender, EventArgs e)
        {
            Form1 irForm1 = new Form1();
            irForm1.Show();
            this.Hide();
        }
    }
}
