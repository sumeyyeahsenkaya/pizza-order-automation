﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameText.Text == "" || passwordText.Text == "")
            {
                MessageBox.Show("Eksik Veri");
            }
            else if (nameText.Text == "Admin" || passwordText.Text == "Password")
            {
                Form1 f1 = new Form1();
                f1.Show();
               
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre");
            }



            
        }
    }
}
