using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Registration : Form
    {
        public Registration()
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
                passwordBox.UseSystemPasswordChar = true;
                passwordBox.Text = "";
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.UseSystemPasswordChar=false;
                passwordBox.Text = "Enter Password...";
            }
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Enter Name...")
                nameBox.Text = "";
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
                nameBox.Text = "Enter Name...";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text.ToLower();
            if (AirBNE.users.Count != 0)
            {
                foreach(User user in AirBNE.users)
                {
                    if (user.UserName.ToLower().Equals(username))
                    {
                        MessageBox.Show("Invalid Credentials!");
                        return;
                    }
                }
            }
            User createdUser = new User(usernameBox.Text,passwordBox.Text,nameBox.Text);
            AirBNE.users.Add(createdUser);
            AirBNE.user=createdUser;
            IFormatter otherFormatter = new BinaryFormatter();
            using (Stream stream = new FileStream("users.mdl", FileMode.Append, FileAccess.Write, FileShare.None))
            {
                otherFormatter.Serialize(stream, createdUser);
            }
            AirBNE form = new AirBNE();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
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
