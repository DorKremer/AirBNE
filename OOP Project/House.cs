using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Project
{
    public class House:Home
    {
        private int floors;
        private bool yard;

        public override string toString()
        {
            return base.toString() + "House Information ::"+"\n"+"##################"+"\n"+"Floors: " + floors + "\nYard: " + yard;
        }

        public House() : base()
        {
            base.Address = "House";
            floors = 0;
            yard = false;
        }

        public House(string address, string description, int zipCode, double price, int residents, bool pets, bool pool, bool wifi, int floors, bool yard, int roomCount):base(address, description, zipCode, price, residents, pets, pool, wifi, roomCount)
        {
            this.floors = floors;
            this.yard = yard;
        }

        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }

        public bool Yard
        {
            get { return yard; }
            set { yard = value; }
        }
    }
}