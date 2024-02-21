using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
   
    public partial class Form5 : Form
    {
        SqlConnection con = new Database().DB();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Registration' table. You can move, or remove it, as needed.
          //  this.registrationTableAdapter.Fill(this.studentDataSet.Registration);

            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Student_Details", con);
           SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();

           
            con.Close();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sd = new Form2();
            sd.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
