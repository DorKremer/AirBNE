using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class ItemChoice : Form
    {
        public ItemChoice()
        {
            InitializeComponent();
        }

        private void apartmentButton_Click(object sender, EventArgs e)
        {
            CreateApartment form = new CreateApartment();
            form.Location = this.Location;
            form.Size = this.Size;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void houseButton_Click(object sender, EventArgs e)
        {
            CreateHouse form = new CreateHouse();
            form.Location = this.Location;
            form.Size = this.Size;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void hotelRoomButton_Click(object sender, EventArgs e)
        {
            CreateHotelRoom form = new CreateHotelRoom();
            form.Location = this.Location;
            form.Size = this.Size;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
    }
}
