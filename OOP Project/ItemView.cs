using OOP_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class ItemView : Form
    {
        public static int itemID = -1;
        public ItemView()
        {
            InitializeComponent();
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            foreach (Rentable item in AirBNE.list)
            {
                renderButton(item);
            }
        }
        private void renderButton(Rentable item)
        {
            Button button = new Button();
            switch (item.GetType().Name)
            {
                case "Apartment":
                    button.BackgroundImage = Properties.Resources.Apartment;
                    break;
                case "House":
                    button.BackgroundImage = Properties.Resources.House;
                    break;
                case "HotelRoom":
                    button.BackgroundImage = Properties.Resources.Hotel;
                    break;

            }
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.Name = Convert.ToString(item.Id);
            button.Size = new Size(350, 250);
            button.Text = item.getText();
            button.Click += new EventHandler(this.itemClick);
            flowLayoutPanel1.Controls.Add(button);

        }
        private void itemClick(object sender, EventArgs e)
        {
            foreach(Control control in flowLayoutPanel1.Controls)
            {
                if (sender.Equals(control))
                {
                    ItemInfo.itemID = Convert.ToInt32(control.Name);
                    break;
                }
            }
            ItemInfo form = new ItemInfo();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { 
                flowLayoutPanel1.Controls.Clear();
                foreach (Rentable item in AirBNE.list)
                {
                    renderButton(item);
                }
                this.Show();
            };
            form.Show();
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string name1 = "";
            string name2 = textBox1.Text.ToLower();
            foreach (Rentable item in AirBNE.list)
            {
                name1 = item.Address.ToLower();
                if (name1.Contains(name2))
                    renderButton(item);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Rentable item in AirBNE.list)
            {
                renderButton(item);
            }
        }
    }
}
