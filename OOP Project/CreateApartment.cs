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
    public partial class CreateApartment : Form
    {
        public CreateApartment()
        {
            InitializeComponent();
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

        private void createBox_Click(object sender, EventArgs e)
        {
            int size=AirBNE.list.Count;
            Apartment apartment = new Apartment(addressBox.Text, descriptionBox.Text, Convert.ToInt32(zipCodeBox.Value), Convert.ToDouble(priceBox.Value), Convert.ToInt32(residentsBox.Value), petsBox.Checked, poolBox.Checked, wifiBox.Checked, Convert.ToInt32(roomCountBox.Value), Convert.ToInt32(floorBox.Value), porchBox.Checked, elevatorBox.Checked);
            AirBNE.list.Add(apartment);
            if (size < AirBNE.list.Count)
                successText.Text = "The Apartment Was Successfully Added To The List!";
        }

        private void descriptionBox_Enter(object sender, EventArgs e)
        {
            if(descriptionBox.Text== "Enter Description...")
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
    }
}
