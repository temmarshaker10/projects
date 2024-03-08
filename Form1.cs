namespace PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnUserName.Text == "temmar10" && btnPassword.Text == "1c2h3a4k5e")
            {
                new Form2().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("the User name or password you entered is incorrect, try again");
                btnPassword.Clear();
                btnUserName.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 signup=new Form3();
            signup.Show();
        }
    }
}
