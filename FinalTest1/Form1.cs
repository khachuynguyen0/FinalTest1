﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("origin: Hello, World!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("push L1: Hello, World!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
