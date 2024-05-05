namespace Vallahson
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UsarNametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserNametb.Text;
            string password = passtb.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else if (username == "admin" && password == "1234")
            {
                DashBoard ds = new DashBoard();
                ds.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Username or password is wrong!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
