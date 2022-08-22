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
            House house = new House(addressBox.Text,descriptionBox.Text,Convert.ToInt32(zipCodeBox.Value),Convert.ToDouble(priceBox.Value),Convert.ToInt32(residentsBox.Value),petsBox.Checked,poolBox.Checked,wifiBox.Checked,Convert.ToInt32(floorsBox.Value),yardBox.Checked,Convert.ToInt32(roomCountBox.Value));
            AirBNE.list.Add(house);
           
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


        private void CreateHouse_Load(object sender, EventArgs e)
        {

        }
    }
}
