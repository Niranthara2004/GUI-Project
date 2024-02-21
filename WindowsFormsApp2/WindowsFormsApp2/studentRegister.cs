using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class studentRegister : Form
    {
        public studentRegister()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            if(txtStudentName.Text=="" || txtStudentName.Text == null)
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtEmail.Text == null)
            {
                MessageBox.Show("Enter Email");
            }
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtNIC.Text == "" || txtNIC.Text == null)
            {
                MessageBox.Show("Enter NIC number");
            }
        }
    }
}
