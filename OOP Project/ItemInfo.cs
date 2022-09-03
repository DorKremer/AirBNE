using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            foreach (Rentable item in AirBNE.list)
            {
                if (itemID == item.Id)
                {
                    this.item = item;
                    break;
                }
            }
            label1.Text = item.toString();
        }

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            if (AirBNE.user == null)
            {
                deleteButton.Visible = false;
                orderBox.Visible = false;
                return;
            }
            else
            {
                orderBox.Visible = true;
            }
            if (item.User.UserName == AirBNE.user.UserName)
            {
                deleteButton.Visible = true;
            }
            else
            {
                deleteButton.Visible = false;
            }

        }

        private void orderBox_Click(object sender, EventArgs e)
        {
            foreach (Rentable item in AirBNE.list)
            {
                if (itemID != item.Id)
                    item.Occupied = false;
            }
            foreach (Rentable item in AirBNE.list)
            {
                if (itemID == item.Id)
                {
                    if (item.Occupied == true)
                    {
                        MessageBox.Show("Not Available");
                    }

                    else
                    {
                        item.Occupied = true;
                        AirBNE.user.Item = item;
                        break;
                    }
                }
            }
            label1.Text = item.toString();
            AirBNE.removedContent = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Order.item = null;
            AirBNE.list.Remove(item);
            MessageBox.Show("Item Removed");
            AirBNE.removedContent = true;
            if (item == AirBNE.user.Item)
            {
                AirBNE.user.Item = null;
            }
            ItemView form = new ItemView();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ItemView form = new ItemView();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(234, 234, 234), Color.FromArgb(255, 94, 0), 65F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }
    }
}
