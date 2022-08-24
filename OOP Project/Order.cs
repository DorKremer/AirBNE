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
        public static Rentable order=null;

        private void Order_Load(object sender, EventArgs e)
        {
            if (order != null)
            {
                label1.Text = order.toString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                MessageBox.Show("Your Order List Is Empty");

            }
            else
            {
                foreach (Rentable item in AirBNE.list)
                {
                    if (order.Id == item.Id)
                    {
                        item.Occupied = false;
                        label1.Text = "Empty";
                        MessageBox.Show("Check out Complate");
                        break;
                    }

                }
                order = null;
            }
        }
    }
}
