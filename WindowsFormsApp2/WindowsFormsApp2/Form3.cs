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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        SqlConnection con = new Database().DB();
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtEmail.Text == null)
            {
                MessageBox.Show("Enter email");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.Show();
            Hide();

        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {
            if(txtSName.Text == "" || txtSName.Text == null)
            {
                MessageBox.Show("Enter name");
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtAddress.Text == null)
            {
                MessageBox.Show("Enter address");
            }
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtNIC.Text == "" || txtNIC.Text == null)
            {
                MessageBox.Show("Enter NIC");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtID.Text == null)
            {
                MessageBox.Show("Enter student ID");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

              /*  string gender = cmbGender.SelectedItem.ToString();
                string course = cmbCourse.SelectedItem.ToString();
                string batch = cmbBatch.SelectedItem.ToString();*/
                string date=dtmBirthday.Value.ToString();
                
                con.Open();
              
                SqlCommand cmd = new SqlCommand("INSERT INTO Student_Details VALUES(@StudentID,@StudentName,@Address,@Birthday,@Gender,@TelNumber,@Email,@NICnumber,@Course,@Batch)", con);
                cmd.Parameters.AddWithValue("@StudentID", txtID.Text);
                cmd.Parameters.AddWithValue("@StudentName", txtSName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Birthday", date);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@TelNumber", txtTelephone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NICnumber", txtNIC.Text);
                cmd.Parameters.AddWithValue("@Course", cmbCourse.Text);
                cmd.Parameters.AddWithValue("@Batch", cmbBatch.Text);
                cmd.ExecuteNonQuery();

               /* if (Result == 1) {

                    MessageBox.Show("Data Sent");

                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }*/
                con.Close();
                MessageBox.Show("Data Sent.");
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dtmBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
};