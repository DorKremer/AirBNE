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
    public partial class ItemView : Form
    {
        public ItemView()
        {
            InitializeComponent();
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            foreach (Rentable item in AirBNE.list)
            {
                Button button = new Button();
                button.Size = new Size(350, 250);
                button.Text = item.getText();
                flowLayoutPanel1.Controls.Add(button);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string name1 = "";
            string name2 = textBox1.Text.ToLower();
            foreach (Rentable item in AirBNE.list)
            {
                name1 = item.Address.ToLower();
                if (name1.Contains(name2))
                {
                    Button button = new Button();
                    button.Size = new Size(350, 250);
                    button.Text = item.getText();
                    flowLayoutPanel1.Controls.Add(button);
                }
            }
        }
    }
}
