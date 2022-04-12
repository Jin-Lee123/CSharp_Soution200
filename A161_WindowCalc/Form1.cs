using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A161_WindowCalc
{
    public partial class Form1 : Form
    {
        private double saved;
        private double memory;
        private char op = '\0';
        private bool opFlag = false;
        private bool memFlag;
        private bool percentFlalg;

        public Form1()
        {
            InitializeComponent();

            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("."))
                return;
            else
                txtResult.Text += ".";  
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Text;

            if (txtResult.Text == "0" || opFlag == true || memFlag == true)
            {
                txtResult.Text = s;
                opFlag = false;
                memFlag = false;
            }
            else
                txtResult.Text = txtResult.Text + s;

            txtResult.Text = GroupSeparator(txtResult.Text);
        }

        private void btnOp(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            saved = Double.Parse(txtResult.Text);
            txtExp.Text += txtResult.Text + " " + btn.Text + " ";
            op = btn.Text[0];
            opFlag = true;
            percentFlalg = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Double value = Double.Parse(txtResult.Text);
            switch (op)
            {
                case '+':
                    txtResult.Text = (saved + value).ToString();
                    break;
                case '-':
                    txtResult.Text = (saved - value).ToString();
                    break;
                case '*':
                    txtResult.Text = (saved * value).ToString();
                    break;
                case '/':
                    txtResult.Text = (saved / value).ToString();
                    break;
            }
            txtResult.Text = GroupSeparator(txtResult.Text);
            txtExp.Text = "";
        }

        private string GroupSeparator(string s)
        {
            int pos = 0;   
            double v = Double.Parse(s);

            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');
                if (pos == 1)
                    return s;
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);
            }
            else
                s = string.Format("{0:N0}", v);
            return s;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtExp.Text = "v(" +txtResult.Text + ") ";
            txtResult.Text =Math.Sqrt(Double.Parse(txtResult.Text)).ToString();
            txtResult.Text = GroupSeparator(txtResult.Text);
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            txtExp.Text = "sqr(" + txtResult.Text + ") ";
            txtResult.Text = (Double.Parse(txtResult.Text) * Double.Parse(txtResult.Text)).ToString();
            txtResult.Text = GroupSeparator(txtResult.Text);
        }

        private void btnRecip_Click(object sender, EventArgs e)
        {
            txtExp.Text = "1 / (" + txtResult.Text + ") ";
            txtResult.Text = (1/Double.Parse(txtResult.Text)).ToString();
            txtResult.Text = GroupSeparator(txtResult.Text);
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double v = Double.Parse(txtResult.Text);
            txtResult.Text = (-v).ToString();
            txtResult.Text = GroupSeparator(txtResult.Text);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if(percentFlalg == true)
            {
                double p = Double.Parse(txtResult.Text);
                p = saved * p / 100.0;
                txtResult.Text = p.ToString();
                txtExp.Text += txtResult.Text;
                percentFlalg = false;
            }
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(txtResult.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            memFlag = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtResult.Text = memory.ToString();
            memFlag = true;
            txtResult.Text = GroupSeparator(txtResult.Text);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            memory = 0;
            btnMC.Enabled=false;
            btnMR.Enabled=false;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(txtResult.Text);
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(txtResult.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtExp.Text = "";
            saved = 0;
            op = '\0';
            opFlag = false;
            percentFlalg = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "0";
        }
    }
}
