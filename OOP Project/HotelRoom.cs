using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;

namespace OOP_Project
{
    public class HotelRoom : Rentable
    {
        private string hotelName;
        private bool gym;
        private int roomNumber;
        private byte pension;
        private byte hotelGrade;
        public override string toString()
        {
            return base.toString()+"\nHotel Name: "+hotelName+"\ngym: " +gym + "\nroomNumber: " + roomNumber + "\npension: " + pension + "\nhotelGrade: " + hotelGrade;
        }
        public HotelRoom() : base()
        {
            base.Address = "Hotel Room";
            hotelName = "";
            gym = false;
            roomNumber = 0;
            pension = 0;
            hotelGrade = 0;
        }
        public HotelRoom(string hotelName, string address, string description, int zipCode, double price, int residents, bool pets, bool pool, bool wifi,bool gym, int roomNumber,byte pension,byte hotelGrade) : base(address, description, zipCode, price, residents, pets, pool, wifi)
        {
            this.hotelName = hotelName;
            this.gym = gym;
            this.roomNumber = roomNumber;
            this.pension = pension;
            this.hotelGrade = hotelGrade;
        }

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
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