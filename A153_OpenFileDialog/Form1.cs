using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Security;

namespace A153_OpenFileDialog
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "Select a text file ";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.Title = "Open text file";
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                }
                catch ( SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message:" +
                        $"{ex.Message}\n\n" + $"Detail:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
