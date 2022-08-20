using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OOP_Project
{
    public class Apartment:Home
    {
        private int floor;
        private bool porch;
        private bool elevator;

        public Apartment():base()
        {
            floor = 0;
            porch = false;
            elevator = false;
        }

        public Apartment(int floor, bool porch,bool elevator) : base()
        {
            floor = 0;
            porch = false;
            elevator = false;
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