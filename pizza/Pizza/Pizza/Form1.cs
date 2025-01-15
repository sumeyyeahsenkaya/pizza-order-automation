using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(isimText.Text, soyisimText.Text, pizzaKombo.Text, hamurKombo.Text, boyutKombo.Text, adetKombo.Text, icecekKombo.Text);
           
            isimText.Text = "";
            soyisimText.Text = "";
            pizzaKombo.Text = "";
            hamurKombo.Text = "";
            boyutKombo.Text = "";
            adetKombo.Text = "";
            icecekKombo.Text = "";

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
