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
        private bool gym;
        private int roomNumber;
        private byte pension;
        private byte hotelGrade;
        public string toString()
        {
            return "address: " + base.Address + "\n" + "description: " + base.Description + "\n" + "zip Code: " + base.ZipCode + "\n" + "price: " + base.Price + "\n" + "residents: " + base.Residents + "\n" + "pets: " + base.Pets + "\n" + "occupied: " + base.Occupied + "\n" + "pool: " + base.Pool + "\n" + "wifi: " + base.Wifi + "\n"+"gym: " +gym + "\n" + "roomNumber: " + roomNumber + "\n" + "pension: " + pension + "\n" + "hotelGrade: " + hotelGrade;
        }
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