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
            Rentable[] realestate = AirBNE.list.ToArray(typeof(Rentable)) as Rentable[];
            for(int i = 0; i < AirBNE.list.Count; i++)
            {
                if (i == 0)
                    label1.Text = realestate[i].toString() + "\n\n";
                else
                    label1.Text += realestate[i].toString() + "\n\n";
            }
        }
    }
}
