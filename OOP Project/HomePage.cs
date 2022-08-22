using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class AirBNE : Form
    {
        public static List<Rentable> list = new List<Rentable>();

        public AirBNE()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                ItemChoice form = new ItemChoice();
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Show(); };
                form.Show();
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemView form = new ItemView();
            Random random = new Random();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

      
    }
}
