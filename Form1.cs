﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 記帳SQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("選擇項目", "注意");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SearchByMonth r = new SearchByMonth();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account ac = new account();
            ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchByYear year = new SearchByYear();
            year.Show();
        }
    }
}