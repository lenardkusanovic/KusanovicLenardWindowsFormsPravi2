﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KusanovicLenardTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // obrada Tick dogadjaja
        private void timer1_Tick(object sender, EventArgs e)
        {
            // upis trenutnog vremena u label kontroli
            labelVrijeme.Text = DateTime.Now.ToShortTimeString();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            {
                // pokretanje timer-a
                timer1.Start();

            }

        }
    }
}
