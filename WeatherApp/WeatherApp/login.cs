using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class login : Form
    {
        WeatherDBEntities db;
        public login()
        {
            InitializeComponent();
            db = new WeatherDBEntities();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            vUsers loginUser = new vUsers();
            try
            {
                loginUser = db.vUsers.First(f => (f.UserLogin == login & f.UserPassword == password));
            }
            catch
            {
                MessageBox.Show("There,s no such user!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (loginUser.TypeName)
            {
                case "standardUser":
                    MessageBox.Show("Hello, user!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StandardUserForm newStandardUserForm = new StandardUserForm(db);
                    newStandardUserForm.Show();
                    break;
                case "admin":
                    MessageBox.Show("Hello, admin!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainWindow newMainWindow = new MainWindow(db);
                    newMainWindow.Show();
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
