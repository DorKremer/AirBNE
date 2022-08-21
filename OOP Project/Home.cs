using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Project
{
    public abstract class Home:Rentable
    {
        private int roomCount;

        public Home() : base()
        {
            roomCount = 0;
        }

        public Home(string address, string description, int zipCode, double price, int residents, bool pets, bool pool, bool wifi,int roomCount) : base(address, description, zipCode, price, residents, pets, pool, wifi)
        {
            this.roomCount = roomCount;
        }
        public int RoomCount
        {
            get { return roomCount; }
            set { roomCount = value; }
        }

        public override string toString()
        {
            return base.toString()+"\nRoom Count: "+roomCount;
        }
    }
}