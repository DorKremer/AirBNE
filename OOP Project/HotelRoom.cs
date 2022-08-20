using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OOP_Project
{
    public class HotelRoom : Rentable
    {
        private bool gym;
        private int roomNumber;
        private byte pension;
        private byte hotelGrade;
        public HotelRoom() : base()
        {
            gym = false;
            roomNumber = 0;
            pension = 0;
            hotelGrade = 0;
        }

        public HotelRoom(bool gym, int roomNumber,byte pension,byte hotelGrade) : base()
        {
            this.gym = gym;
            this.roomNumber = roomNumber;
            this.pension = pension;
            this.hotelGrade = hotelGrade;
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