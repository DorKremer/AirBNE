using System;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class AirBNE : Form
    {
        HotelRoom room = new HotelRoom();
        public AirBNE()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AirBNE_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            room.Address = textBox1.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            room.Description= textBox11.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            room.ZipCode = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            room.Price = Convert.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            room.Residents = Convert.ToInt32(numericUpDown3.Value);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            room.RoomNumber = Convert.ToInt32(numericUpDown4.Value);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            room.Pension = Convert.ToByte(numericUpDown5.Value);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            room.HotelGrade = Convert.ToByte(numericUpDown6.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            room.Pets= checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            room.Occupied = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            room.Pool = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            room.Wifi = checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            room.Gym = checkBox5.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label14.Text = room.toString();
        }
    }
}
