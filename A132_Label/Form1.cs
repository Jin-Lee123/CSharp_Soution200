using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A132_Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string raffaello = "라파엘로 신차오, 이탈리아, 르테상스 3대 거장, 1483~1520";
            string schoolOfAthens = "~~~~~~";

            label1.Text = raffaello;
            label2.Text = schoolOfAthens;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }
    }
}
