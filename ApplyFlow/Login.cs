using System;
using System.Windows.Forms;

namespace ApplyFlow
{
    public partial class FormLogin : Form
    {

        private UserService userService = new UserService();
        public FormLogin()
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
                User.GetInstance().SetPassword(password);
                //MessageBox.Show("Welcome " + username + ".", "ApplyFlow");
                FormHome home = new FormHome();
                this.Hide();
                home.Show(); // load home window
            }
            else { MessageBox.Show("Login failed. Invalid credentials.", "Login Error"); }
        }
    }
}
