namespace HotelManagement
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> validUsers;

        public Form1()
        {
            InitializeComponent();
            InitializeValidUsers();
        }

        private void InitializeValidUsers()
        {
            validUsers = new Dictionary<string, string>
            {
                { "admin", "pass" },
                { "user1", "1234" },
                {"shakthi@intellect.com", "sha@20"  }
                // Add more valid usernames and passwords as needed
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AuthenticateUser(txtUsername.Text, txtPassword.Text))
            {
                labelError.Visible = false;
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool AuthenticateUser(string username, string password)
        {
            if (validUsers.ContainsKey(username))
            {
                string storedPassword = validUsers[username];
                return password == storedPassword;
            }
            return false;
        }
    }
}
