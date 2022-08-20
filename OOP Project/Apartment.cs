using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OOP_Project
{
    public class Apartment:Rentable
    {
        private int roomCount;
        private int floor;
        private bool porch;
        private bool elevator;

        public Apartment():base()
        {
            roomCount = 0;
            floor = 0;
            porch = false;
            elevator = false;
        }

        public int RoomCount
        {
            get { return roomCount; }
            set { roomCount = value; }
        }
        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }
        public bool Porch
        {
            get { return porch; }
            set { porch = value; }
        }
        public bool Elevator
        {
            get { return elevator; }
            set { elevator = value; }
        }

    }
}