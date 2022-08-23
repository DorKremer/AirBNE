using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class AirBNE : Form
    {
        public static List<Rentable> list = new List<Rentable>();

        public AirBNE()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                ItemChoice form = new ItemChoice();
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Show(); };
                form.Show();
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Rentable thing = null;
                switch (random.Next(3))
                {
                    case 0:
                        thing = new House();
                        break;
                    case 1:
                        thing = new Apartment();
                        break;
                    case 2:
                        thing = new HotelRoom();
                        break;
                }
                list.Add(thing);
            }
            ItemView form = new ItemView();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
    }
}
