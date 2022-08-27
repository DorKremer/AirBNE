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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        public static Rentable item=null;

        private void Order_Load(object sender, EventArgs e)
        {
            if (item != null)
            {
                label1.Text = item.toString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                MessageBox.Show("Your Order List Is Empty");

            }
            else
            {
                foreach (Rentable item in AirBNE.list)
                {
                    if (Order.item.Id == item.Id)
                    {
                        item.Occupied = false;
                        label1.Text = "Empty";
                        MessageBox.Show("Check out Complete");
                        break;
                    }

                }
                item = null;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AirBNE form = new AirBNE();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
    }
}
