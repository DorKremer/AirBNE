using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OOP_Project
{
    public class HotelRoom : Rentable
    {
        private bool pool;
        private bool gym;
        private int roomNumber;
        private byte pension;
        private byte hotelGrade;
        public HotelRoom() : base()
        {
            pool = false;
            gym = false;
            roomNumber = 0;
            pension = 0;
            hotelGrade = 0;
        }

        public bool Pool
        {
            get { return pool; }
            set { pool = value; }
        }

        public bool Gym
        {
            get { return gym; }
            set { gym = value; }
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public byte Pension
        {
            get { return pension; }
            set { pension = value; }
        }

        public byte HotelGrade
        {
            get { return hotelGrade; }
            set { hotelGrade = value; }
        }
    }

}