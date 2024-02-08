using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sliit_proj
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = form_username.Text;
            string password = form_password.Text;
            string email = form_email.Text;
            string cpassword = form_cpassword.Text;
            string firstname = form_firstname.Text;
            string lastname = form_lastname.Text;

            if (password == cpassword)
            {
                Program.registerUser(username, password, email, firstname, lastname);
            } else
            {
                MessageBox.Show("Password Doesn't Match");
            }
        }
    }
}
