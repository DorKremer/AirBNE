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
    public partial class ItemInfo : Form
    {
        public static int itemID = -1;
        Rentable item;
        public ItemInfo()
        {
            InitializeComponent();
        }

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            foreach(Rentable item in AirBNE.list)
            {
                if (itemID == item.Id)
                {
                    this.item = item;
                    break;
                }

            }
            label1.Text =item.toString();
        }

        private void orderBox_Click(object sender, EventArgs e)
        {
            foreach(Rentable item in AirBNE.list)
            {
                if(itemID == item.Id)
                {
                    item.Occupied = true;
                    break;
                }
            }
            label1.Text = item.toString();

        }
    }
}
