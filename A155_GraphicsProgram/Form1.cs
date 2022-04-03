using System.Windows.Forms;
using System;
using System.Drawing;

namespace A155_GraphicsProgram
{
    enum DrawMode { LINE, RECTANGLE, CIRCLE, CURVE_LINE};

    public partial class Form1 : Form
    {
        private DrawMode drawMode;
        private Graphics g;
        private Pen pen = new Pen(Color.Black, 2);
        private Pen eraser;
        Point startP;
        Point endP;
        Point currP;
        Point prevP;

        public Form1()
        {
            InitializeComponent();

            g= CreateGraphics();
            toolStripStatusLabel1.Text = "Line Mode";
            this.BackColor = Color.White;
            this.eraser = new Pen(this.BackColor, 2);
        }

        
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.LINE;
            toolStripStatusLabel1.Text = "Line Mode";
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.RECTANGLE;
            toolStripStatusLabel1.Text = "RECTANGLE Mode";
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.CIRCLE;
            toolStripStatusLabel1.Text = "CIRCLE Mode";
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.CURVE_LINE;
            toolStripStatusLabel1.Text = "CURVE_LINE Mode";
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if ( colorDialog.ShowDialog() == DialogResult.OK )
                pen.Color = colorDialog.Color;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startP = new Point(e.X, e.Y);
            prevP = startP;
            currP = startP;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            prevP = currP;
            currP = new Point(e.X, e.Y);

            switch(drawMode)
            {
                case DrawMode.LINE:
                    g.DrawLine(eraser, startP, prevP);
                    g.DrawLine(pen, startP, currP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(eraser, new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawRectangle(pen, new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(eraser, new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawEllipse(pen, new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CURVE_LINE:
                    g.DrawLine(pen, prevP, currP);
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            endP = new Point(e.X, e.Y);
            switch(drawMode)
            {
                case DrawMode.LINE:
                    g.DrawLine(pen, startP, endP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(pen, new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y))); 
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(pen, new Rectangle(startP, new Size(endP.X- startP.X, endP.Y -startP.Y)));
                    break;
                case DrawMode.CURVE_LINE:
                    break;
            }
        }
    }
}
