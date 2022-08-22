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
            HotelRoom hotelRoom = new HotelRoom(hotelNameBox.Text,addressBox.Text,descriptionBox.Text,Convert.ToInt32(zipCodeBox.Value),Convert.ToDouble(priceBox.Value),Convert.ToInt32(residentsBox.Value),petsBox.Checked,poolBox.Checked,wifiBox.Checked,gymBox.Checked,Convert.ToInt32(roomNumberBox.Value),Convert.ToByte(pensionBox.Value),Convert.ToByte(hotelGrade.Value));
            AirBNE.list.Add(hotelRoom);
            if (size < AirBNE.list.Count)
                successText.Text = "The Room Was Successfully Added To The List!";
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

        private void createBox_Leave(object sender, EventArgs e)
        {
            successText.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hotelNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
