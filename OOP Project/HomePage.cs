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
                label1.Text = user.Id+"";
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    foreach(Rentable item in list)
                        formatter.Serialize(stream, item);
                }
            }
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "users.mdl";
            IFormatter otherFormatter = new BinaryFormatter();
            using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                foreach (User user in users)
                    otherFormatter.Serialize(stream, user);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if(list.Count!=0)
                list.Clear();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Rentable item;
                while(stream.Position < stream.Length)
                {
                    item = (Rentable)binaryFormatter.Deserialize(stream);
                    if (item.Occupied)
                        Order.item = item;
                    list.Add(item);
                }
                pictureBox1.Invalidate();
            }
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "users.mdl";
            Stream otherStream = File.Open(openFileDialog1.FileName, FileMode.Open);
            var otherFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            User user;
            while (otherStream.Position < otherStream.Length)
            {
                user = (User)otherFormatter.Deserialize(otherStream);
                users.Add(user);
            }
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
