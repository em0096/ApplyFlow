using System;
using System.Windows.Forms;

namespace ApplyFlow
{
    public partial class Login : Form
    {

        private UserService userService = new UserService();
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            if (userService.authenticateUser(username, password))
            {
                User.GetInstance().SetUsername(username);
                User.GetInstance().SetUsername(password);
                MessageBox.Show("Welcome " + username + ".", "ApplyFlow");
                Home home = new Home();
                this.Hide();
                home.Show(); // load home window
            }
            else { MessageBox.Show("Login failed. Invalid credentials.", "Login Error"); }
        }
    }
}
