using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A154_Menu
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();

            label1.Text = "";
            label1.Font = new Font("맑은 고딕", 20, FontStyle.Bold);
            t.Interval = 1000;
            t.Tick += timer1_Tick;
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(
                ClientSize.Width /2 -label1.Width / 2,
                ClientSize.Height /2 -label1.Height / 2);
            label1.Text = DateTime.Now.ToString();
        }

        private void 폰트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fDlg = new FontDialog();

            fDlg.ShowColor = true;
            fDlg.ShowEffects = true;
            fDlg.Font = label1.Font;
            fDlg.Color = label1.ForeColor;

            if(fDlg.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fDlg.Font;
                label1.ForeColor = fDlg.Color;
            }
        }

        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDlg = new ColorDialog();
            if(cDlg.ShowDialog(this) == DialogResult.OK)
            {
                this.BackColor = cDlg.Color;
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
