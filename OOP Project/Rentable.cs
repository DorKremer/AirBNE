using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Project
{
    public abstract class Rentable
    {
        //Picture
        private string address;
        private string description;
        private int zipCode;
        private double price;
        private int residents;
        private bool pets;
        private bool occupied;
        private bool pool;
        private bool wifi;

        //public string toString()
        //{
        //    return "address: "+address + "\n" + "description: " + description + "\n" + "zip Code: " + zipCode + "\n" + "price: " + price + "\n" + "residents: " + residents + "\n" + "pets: " + pets + "\n" + "occupied: " + occupied + "\n" + "pool: " + pool + "\n" + "wifi: " + wifi + "\n";
        //}

        public Rentable()
        {
            this.address = "";
            this.description = "";
            this.price = 0;
            this.zipCode = 0;
            this.residents = 0;
            this.pets = false;
            this.occupied = false;
            this.pool = false;
            this.wifi = false;
        }
        Rentable(string address,string description,int zipCode,double price, int residents, bool pets,bool occupied,bool pool,bool wifi)
        {
            this.address = address;
            this.description = description;
            this.zipCode = zipCode;
            this.price = price;
            this.residents = residents;
            this.pets = pets;
            this.occupied = occupied;
            this.pool = pool;
            this.wifi = wifi;
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int ZipCode 
        { 
            get { return zipCode; }
            set { zipCode = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool Pets
        {
            get { return pets; }
            set { pets = value; }
        }
        public int Residents
        {
            get { return residents; }
            set { residents = value; }
        }
        public bool Occupied
        {
            get { return occupied; }
            set { occupied = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Pool
        {
            get { return pool; }
            set { pool = value; }
        }

        public bool Wifi
        {
            get { return wifi; }
            set { wifi = value; }
        }

    }
}