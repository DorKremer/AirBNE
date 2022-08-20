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

        public House() : base()
        {
            floors = 0;
            yard = false;
        }

        public House(int floors, bool yard):base()
        {
            this.floors = floors;
            this.yard = yard;
        }
    }
}