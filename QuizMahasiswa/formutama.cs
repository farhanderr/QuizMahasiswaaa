﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMahasiswa
{
    public partial class formutama : Form
    {
        public formutama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Masterbarang018 a = new Masterbarang018();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportBarang009 a = new ReportBarang009();
            a.Show();
        }

        private void formutama_Load(object sender, EventArgs e)
        {

        }
    }
}
