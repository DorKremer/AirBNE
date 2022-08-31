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
    public partial class CreateHouse : Form
    {
        public CreateHouse()
        {
            InitializeComponent();
        }

        private void createBox_Click(object sender, EventArgs e)
        {
            int size=AirBNE.list.Count;
            House house = new House(addressBox.Text,descriptionBox.Text,Convert.ToInt32(zipCodeBox.Value),Convert.ToDouble(priceBox.Value),Convert.ToInt32(residentsBox.Value),petsBox.Checked,poolBox.Checked,wifiBox.Checked,AirBNE.user, Convert.ToInt32(floorsBox.Value),yardBox.Checked,Convert.ToInt32(roomCountBox.Value));
            AirBNE.list.Add(house);
            MessageBox.Show("House Created");
            AirBNE.addedContent = true;
        }

        private void addressBox_Leave(object sender, EventArgs e)
        {
            if (addressBox.Text == "")
                addressBox.Text = "Enter Address...";
        }

        private void addressBox_Enter(object sender, EventArgs e)
        {
            if(addressBox.Text == "Enter Address...")
                addressBox.Text = "";
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
