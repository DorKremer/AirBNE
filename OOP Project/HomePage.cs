using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace OOP_Project
{
    public partial class AirBNE : Form
    {
        public static List<Rentable> list = new List<Rentable>();
        public static List<User> users = new List<User>();
        public static User user = null;
        public static bool addedContent = false;

        public AirBNE()
        {
            InitializeComponent();
            if (user == null)
            {
                orderButton.Visible = false;
                addItemsButton.Visible = false;
            }
            else
            {
                welcomeText.Text="Welcome, "+user.Name+"!";
                orderButton.Visible = true;
                registerButton.Visible = false;
                loginButton.Visible = false;
                addItemsButton.Visible = true;
            }
            Stream stream;
            if (list.Count == 0)
            {
                if (!File.Exists("items.mdl"))
                {
                    File.Create("items.mdl");
                }
                stream = File.Open("items.mdl", FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Rentable item;
                while (stream.Position < stream.Length)
                {
                    item = (Rentable)binaryFormatter.Deserialize(stream);
                    if (item.Occupied)
                        Order.item = item;
                    list.Add(item);
                }
            }
            if (users.Count == 0)
            {
                stream = File.Open("users.mdl", FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                User userData;
                while (stream.Position < stream.Length)
                {
                    userData = (User)binaryFormatter.Deserialize(stream);
                    users.Add(userData);
                }
            }
        }

        private void itemChoiceButton_Click(object sender, EventArgs e)
        {
            ItemChoice form = new ItemChoice();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void itemViewButton_Click(object sender, EventArgs e)
        {
            ItemView form = new ItemView();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Order form = new Order();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
    }
}
