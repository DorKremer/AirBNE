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


        private void CreateApartment_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void priceBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void residentsBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void roomCountBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
