using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A187_Omok
{
    public partial class Form1 : Form
    {
        int margin = 40;
        int 눈Size = 30;
        int 돌Size = 28;
        int 화점Size = 10;

        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;

        enum STONE { none, black, white };
        STONE[,] 바둑판 = new STONE[19, 19];
        bool flag = false;

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Orange;

            pen = new Pen(Color.Black);
            bBrush = new SolidBrush(Color.Black);
            wBrush = new SolidBrush(Color.White);

            this.ClientSize = new Size(2 * margin + 18 * 눈Size,
                2 * margin + 18 * 눈Size + menuStrip1.Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawBoard();
            DrawStrones();
        }

        private void DrawBoard()
        {
            g = panel1.CreateGraphics();

            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + i * 눈Size, margin),
                    new Point(margin + i * 눈Size, margin + 18 * 눈Size));
                g.DrawLine(pen, new Point(margin, margin + i * 눈Size),
                    new Point(margin + 18 * 눈Size, margin + i * 눈Size));
            }
            for (int x = 3; x <= 15; x += 6)
                for (int y = 3; y <= 15; y += 6)
                {
                    g.FillEllipse(bBrush,
                        margin + 눈Size * x - 화점Size / 2,
                        margin + 눈Size * y - 화점Size / 2,
                        화점Size, 화점Size);
                }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + 눈Size / 2) / 눈Size;
            int y = (e.Y - margin + 눈Size / 2) / 눈Size;

            if (바둑판[x, y] != STONE.none) return;

            Rectangle r = new Rectangle(margin + 눈Size * x - 돌Size / 2,
                margin + 눈Size * y - 돌Size / 2, 돌Size, 돌Size);

            if (flag == false)
            {
                g.FillEllipse(bBrush, r);
                flag = true;
                바둑판[x, y] = STONE.black;
            }
            else
            {
                g.FillEllipse(wBrush, r);
                flag = false;
                바둑판[x, y] = STONE.white;
            }

            CheckOmok(x, y);
        }

        private void CheckOmok(int x, int y)
        {
            int cnt = 1;

            for (int i = x + 1; i <= 18; i++)
                if (바둑판[i, y] == 바둑판[x, y])
                    cnt++;
                else
                    break;

            for (int i = x - 1; i >= 0; i--)
                if (바둑판[i, y] == 바둑판[x, y])
                    cnt++;
                else
                    break;

            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }
        }

        private void OmokComplete(int x, int y)
        {
            DialogResult res = MessageBox.Show(바둑판[x, y].ToString().ToUpper()
                + "Win!\n새로운 게임을 시작할까요", "게임종료",
                MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                NewGame();
            else if (res == DialogResult.No)
                this.Close();
        }

        private void NewGame()
        {
            flag = false;

            for (int x = 0; x < 19; x++)
                for (int y = 0; y < 19; y++)
                    바둑판[x, y] = STONE.none;

            panel1.Refresh();
            DrawBoard();
        
        }

        private void DrawStrones()
        {
            for(int x = 0; x<19; x++)
                for(int y = 0; y<19; y++)
                    if(바둑판[x,y] ==STONE.white)
                        g.FillEllipse(wBrush,margin+x*눈Size-돌Size/2,
                            margin +y*눈Size-돌Size / 2,돌Size,돌Size);
                    else if(바둑판[x, y] == STONE.white)
                        g.FillEllipse(bBrush, margin + x * 눈Size - 돌Size / 2,
                            margin + y * 눈Size - 돌Size / 2, 돌Size, 돌Size);
        }
    }
}
