using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A173_MyNotePad
{
    public partial class Form1 : Form
    {
        private bool modifyFlag = false;
        private string fileName = "noname.txt";

        public Form1()
        {
            InitializeComponent();
            this.Text = fileName + " - nmyNotePad";
        }

        // RichTextBox 의  TextChanged Event 처리 메서드
        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            modifyFlag = true;
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProcessBeforeClose();

            txtMemo.Text = "";
            modifyFlag = false;
            fileName = "noname.txt";
        }

        private void FileProcessBeforeClose()
        {
            if (modifyFlag ==true)
            {
                DialogResult ans = MessageBox.Show("변경된 내용을 저장하겠습니까?", "저장", MessageBoxButtons.YesNo);
                if(ans == DialogResult.Yes)
                {
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                        sw.WriteLine(txtMemo.Text);
                        sw.Close();
                    }
                }
                else
                {
                    StreamWriter sw = File.CreateText(fileName);
                    sw.WriteLine(txtMemo.Text);
                    sw.Close();
                }
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProcessBeforeClose();
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName;
            this.Text = fileName + " - myNotePad";
            try
            {
                StreamReader r = File.OpenText(fileName);
                txtMemo.Text =r.ReadToEnd();
                
                modifyFlag = false;
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( fileName == "noname.txt")
            {
                saveFileDialog1.ShowDialog();
                fileName = saveFileDialog1.FileName;
            }
            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine(txtMemo.Text);

            modifyFlag = false;
            sw.Close();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileProcessBeforeClose();
            Close();
        }

        private void 복사하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox contents = (RichTextBox)ActiveControl;
            if(contents != null)
            {
                Clipboard.SetDataObject(contents.SelectedText);
            }
        }

        private void 붙여놓기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox contents = (RichTextBox)ActiveControl;
            if(contents != null )
            {
                IDataObject data = Clipboard.GetDataObject();
                contents.SelectedText = data.GetData(DataFormats.Text).ToString();
                modifyFlag = true;
            }
        }
    }
}
