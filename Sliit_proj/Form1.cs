namespace Sliit_proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm registerForm = new registerForm();
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
