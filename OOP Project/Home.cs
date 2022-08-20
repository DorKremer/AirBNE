using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Project
{
    public abstract class Home:Rentable
    {
        private int roomCount;
        private int floors;

        public Home() : base()
        {
            roomCount = 0;
            floors = 0;
        }
        public int RoomCount
        {
            get { return roomCount; }
            set { roomCount = value; }
        }

        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }
    }
}