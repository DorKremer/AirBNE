using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace OOP_Project
{
    public partial class AirBNE : Form
    {
        public static List<Rentable> list = new List<Rentable>();

        public AirBNE()
        {
            InitializeComponent();
        }

        private void itemChoiceButton_Click(object sender, EventArgs e)
        {
                ItemChoice form = new ItemChoice();
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Show(); };
                form.Show();
                this.Hide();
        }

        private void itemViewButton_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //for (int i = 0; i < 20; i++)
            //{
            //    Rentable thing = null;
            //    switch (random.Next(3))
            //    {
            //        case 0:
            //            thing = new House();
            //            break;
            //        case 1:
            //            thing = new Apartment();
            //            break;
            //        case 2:
            //            thing = new HotelRoom();
            //            break;
            //    }
            //    list.Add(thing);
            //}
            ItemView form = new ItemView();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Order form = new Order();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    foreach(Rentable item in list)
                        formatter.Serialize(stream, item);
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if(list.Count!=0)
                list.Clear();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Rentable item;
                while(stream.Position < stream.Length)
                {
                    item = (Rentable)binaryFormatter.Deserialize(stream);
                    if (item.Occupied)
                        Order.item = item;
                    list.Add(item);
                }
                pictureBox1.Invalidate();
            }
        }
    }
}
