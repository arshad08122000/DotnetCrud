using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class CRUDForm : Form
    {
        private string SName,SAddress,SGender,SReg,SPhone= "";
        private string CGender,prereg,prephone;
        private int index;
        public CRUDForm()
        {
            InitializeComponent();
        }

        private void Displayallstudents()
        {
            /*SqlConnection conn = DAL.GetConnection();*/
            SqlDataAdapter adapter = new SqlDataAdapter(DAL.Dislpayallstudents());
            DataTable tablee = new DataTable();
            /*SqlCommand cmd = new SqlCommand("SELECT * FROM Student_Table",conn);
            SqlDataReader sdr = cmd.ExecuteReader();*/
            adapter.Fill(tablee);
            /*tablee.Load(sdr);*/
            dataGridViewdetails.DataSource = tablee;
        }

        private void Searchstudents(string Reg)
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter(DAL.Searchstudents(Reg));
            DataTable tablee = new DataTable();
            /*SqlCommand cmd = new SqlCommand("SELECT * FROM Student_Table",conn);
            SqlDataReader sdr = cmd.ExecuteReader();*/
            adapter.Fill(tablee);
            /*tablee.Load(sdr);*/
            
            dataGridViewdetails.DataSource = tablee;
        }
        private void refreshboxes()
        {
            textBoxname.Text = null;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            textBoxname.Text = null;
            textBoxaddress.Text = null;
            textBoxphoneno.Text = null;
            radioButtonfemale.Checked = false;
            radioButtonmale.Checked = false;
            textBox1.Text = null;
            comboBoxregno.SelectedIndex = -1;   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DAL.GetConnection();
            Displayallstudents();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void headtag_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonenotag_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBoxminimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxminimize, "Minimize");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox4, "Refresh");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Search");
        }

        private void textBoxphoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SName = textBoxname.Text;

            SReg = comboBoxregno.SelectedItem.ToString();

            SAddress = textBoxaddress.Text;
            if (radioButtonmale.Checked)
            {
                SGender = "Male";

            }
            else if (radioButtonfemale.Checked)
            {
                SGender = "Female";

            }
            else
            {
                MessageBox.Show("Gender must be specified to add details", "info");
            }

            SPhone = (comboBox1.SelectedItem.ToString() + "-") + textBoxphoneno.Text;
            DAL.UpdateStudent(SName, SReg, SPhone, SAddress, SGender);
            Displayallstudents();
            if (DAL.t == 1)
                refreshboxes();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SReg = comboBoxregno.SelectedItem.ToString();
            DAL.DeleteStudent(SReg);
            Displayallstudents();
            refreshboxes();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Searchstudents(textBox1.Text);
        }

        private void comboBoxregno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                DataGridViewRow row = dataGridViewdetails.Rows[e.RowIndex];
                textBoxname.Text = row.Cells[0].Value.ToString();
                prereg = row.Cells[1].Value.ToString();
                index = comboBoxregno.FindString(prereg);
                comboBoxregno.SelectedIndex = index;
                prephone= row.Cells[2].Value.ToString();
               
                index = comboBox1.FindString(prephone.Substring(0,2));
                textBoxphoneno.Text = prephone.Substring(3,10);
                comboBox1.SelectedIndex = index;
                textBoxaddress.Text = row.Cells[3].Value.ToString();
                CGender = row.Cells[4].Value.ToString();
                if(CGender=="Male")
                {
                    radioButtonmale.Checked=true;
                }
                else
                {
                    radioButtonfemale.Checked = true;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            refreshboxes();
        }

        private void pictureBoxminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void headtag_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(headtag,"CRUD Application");
        }
        
        private void buttoninsert_Click(object sender, EventArgs e)
        {
            SName = textBoxname.Text;
            
            SReg = comboBoxregno.SelectedItem.ToString();
            
            SAddress = textBoxaddress.Text;
            if(radioButtonmale.Checked)
            {
                SGender = "Male";
                
            }
            else if(radioButtonfemale.Checked)
            {
                SGender = "Female";
                
            }
            else
            {
                MessageBox.Show("Gender must be specified to add details","info");
            }

            SPhone = (comboBox1.SelectedItem.ToString()+"-")+textBoxphoneno.Text;
            DAL.AddStudent(SName,SReg,SPhone,SAddress,SGender);
            Displayallstudents();
            if (DAL.t== 1)
                refreshboxes();
            
        }
    }
}
