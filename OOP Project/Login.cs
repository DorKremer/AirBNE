using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void usernameBox_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Enter Username...")
                usernameBox.Text = "";
        }

        private void usernameBox_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
                usernameBox.Text = "Enter Username...";
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Enter Password...")
            {
                passwordBox.Text = "";
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.UseSystemPasswordChar = false;
                passwordBox.Text = "Enter Password...";
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (AirBNE.users.Count == 0)
            {
                MessageBox.Show("Try Signing Up First!");
                return;
            }
            string username=usernameBox.Text.ToLower();
            string password=passwordBox.Text.ToLower();
            foreach(User user in AirBNE.users)
            {
                if (user.UserName.ToLower().Equals(username) && user.Password.ToLower().Equals(password))
                {
                    AirBNE.user=user;
                    AirBNE form = new AirBNE();
                    form.Location = this.Location;
                    form.StartPosition = FormStartPosition.Manual;
                    //foreach(Rentable item in AirBNE.list)
                    //{
                    //    if (item.Id == user.Item.Id)
                    //        Order.item = item;
                    //}
                    form.Show();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Invalid Credentials!");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AirBNE form = new AirBNE();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
    }
}
