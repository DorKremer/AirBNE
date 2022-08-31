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
    public partial class CreateHotelRoom : Form
    {
        public CreateHotelRoom()
        {
            InitializeComponent();
        }

        private void createBox_Click(object sender, EventArgs e)
        {
            int size = AirBNE.list.Count;
            HotelRoom hotelRoom = new HotelRoom(hotelNameBox.Text, addressBox.Text, descriptionBox.Text, Convert.ToInt32(zipCodeBox.Value), Convert.ToDouble(priceBox.Value), Convert.ToInt32(residentsBox.Value), petsBox.Checked, poolBox.Checked, wifiBox.Checked,AirBNE.user, gymBox.Checked, Convert.ToInt32(roomNumberBox.Value), comboBoxPenion.Text, Convert.ToByte(hotelGrade.Value));
            AirBNE.list.Add(hotelRoom);
            MessageBox.Show("Hotel Room Created");
            AirBNE.addedContent = true;
        }

        private void hotelNameBox_Enter(object sender, EventArgs e)
        {
            if (hotelNameBox.Text == "Enter Hotel Name...")
                hotelNameBox.Text = "";
        }

        private void hotelNameBox_Leave(object sender, EventArgs e)
        {
            if (hotelNameBox.Text == "")
                hotelNameBox.Text = "Enter Hotel Name...";
        }

        private void addressBox_Enter(object sender, EventArgs e)
        {
            if (addressBox.Text == "Enter Address...")
                addressBox.Text = "";
        }

        private void addressBox_Leave(object sender, EventArgs e)
        {
            if (addressBox.Text == "")
                addressBox.Text = "Enter Address...";
        }

        private void descriptionBox_Enter(object sender, EventArgs e)
        {
            if (descriptionBox.Text == "Enter Description...")
                descriptionBox.Text = "";
        }

        private void descriptionBox_Leave(object sender, EventArgs e)
        {
            if (descriptionBox.Text == "")
                descriptionBox.Text = "Enter Description...";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ItemChoice form = new ItemChoice();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
    }
}
