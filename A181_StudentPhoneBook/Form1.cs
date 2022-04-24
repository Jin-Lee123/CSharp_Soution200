using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace A181_StudentPhoneBook
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;

        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\wls43\OneDrive\문서\StudentTable.accdb";
        
        public Form1()
        {
            InitializeComponent();
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            ConnetionOpen();

            String sql = "SELECT * FROM StudentTable";
            comm = new OleDbCommand(sql, conn);

            ReadAndAddToListBox();
            ConnetionClose();
        }

        private void ConnetionOpen()
        {
            if (conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();
            }
        }

        private void ReadAndAddToListBox()
        {
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                string x = "";
                x += reader["ID"] + "\t";
                x += reader["SId"] + "\t";
                x += reader["SName"] + "\t";
                x += reader["Phone"];

                listBox1.Items.Add(x);
            }
            reader.Close();
        }

        private void ConnetionClose()
        {
            conn.Close();
            conn = null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if(lb.SelectedItem == null)
                return;

            string[] s = lb.SelectedItem.ToString().Split('\t');
            txtID.Text = s[0];
            txtSld.Text = s[1];
            txtSName.Text = s[2];
            txtPhone .Text = s[3];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSName.Text == "" || txtPhone.Text == "" || txtSld.Text == "")
                return;

            ConnetionOpen();

            string sql = string.Format("insert into" + "StudentTable(Sld, SName, Phone) VALUES({0}, '{1}', '{2}')",
                txtSld.Text, txtSName.Text, txtPhone.Text);

            comm = new OleDbCommand(sql,conn);
            if (comm.ExecuteNonQuery() == 1)
                MessageBox.Show("삽입성공");
            ConnetionClose();
            listBox1.Items.Clear();
            DisplayStudents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSName.Text == "" || txtPhone.Text == "" || txtSld.Text == "")
                return;

            ConnetionOpen();

            string sql = "";
            if (txtSld.Text != "")
                sql = string.Format("SELETE * FROM StudentTable WHERE SID={0}",
                    txtID.Text);
            else if (txtSName.Text != "")
                sql = string.Format("SELETE * FROM StudentTable WHERE SName={0}",
                    txtSName.Text);
            else if (txtPhone.Text != "")
                sql = string.Format("SELETE * FROM StudentTable WHERE txtPhone={0}",
                    txtPhone.Text);

            listBox1.Items.Clear();
            comm = new OleDbCommand(sql, conn);
            ReadAndAddToListBox();
            ConnetionClose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ConnetionOpen();

            String sql = String.Format("UPDATE StudentTable SET SID={0}, SName='{1}', Phone='{2}' WHERE ID ={3}",
                txtID.Text, txtSName.Text, txtPhone.Text, txtID.Text);

            comm = new OleDbCommand(sql,conn);
            if (comm.ExecuteNonQuery() == 1)
                MessageBox.Show("수정 성공!");

            ConnetionClose();
            listBox1.Items.Clear ();
            DisplayStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ConnetionOpen ();

            string sql = string.Format("DELETE FROM StudentTable WHERE ID={0}", txtID.Text);

            comm = new OleDbCommand (sql,conn);
            if (comm.ExecuteNonQuery() == 1)
                MessageBox.Show("삭제 성공");

            ConnetionClose();
            listBox1.Items.Clear () ;
            DisplayStudents ();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSName.Text = "";
            txtPhone.Text = "";
            txtSld.Text = "";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DisplayStudents();
        }



        /*private void DisplayStudents()
        {
            if(conn == null)
            {
                conn = new OleDbConnection(connStr);
                conn.Open();    
            }

            String sql = "SELECT * FROM StudentTable";
            comm = new OleDbCommand(sql, conn);
            reader = comm.ExecuteReader();
            while(reader.Read())
            {
                string x = "";
                x += reader["ID"] + "\t";
                x += reader["SId"] + "\t";
                x += reader["SName"] + "\t";
                x += reader["Phone"];

                listBox1.Items.Add(x);
            }
            reader.Close();
            conn.Close();
            conn = null;
        }*/
    }
}
