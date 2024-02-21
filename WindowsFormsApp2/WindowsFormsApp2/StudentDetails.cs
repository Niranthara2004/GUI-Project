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
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form5 F5= new Form5(); 
            F5.Show();
            Hide();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\Student.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE ID=@ID");
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                int Result = cmd.ExecuteNonQuery();
                if (Result == 1)
                {
                    MessageBox.Show("Data Deleted");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
                con.Close();
            }catch (Exception ex)
            {
               MessageBox.Show( ex.ToString() );    
            }
        }

        private void txtBatch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
