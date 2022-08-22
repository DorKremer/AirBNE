using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Project
{
    public abstract class Rentable
    {
        private static int idCounter = 0;
        //Picture
        private int id;
        private string address;
        private string description;
        private int zipCode;
        private double price;
        private int residents;
        private bool pets;
        private bool occupied;
        private bool pool;
        private bool wifi;

        public virtual string toString()
        {
            return "ID: " + id +"\nOccupied: "+ occupied + "\naddress: " + address + "\n" + "description: " + description + "\n" + "zip Code: " + zipCode + "\n" + "price: " + price + "\n" + "residents: " + residents + "\n" + "pets: " + pets + "\n" + "pool: " + pool + "\n" + "wifi: " + wifi + "\n";
        }
        public string getText()
        {
            return Address + "\n" + Price;
        }
        public Rentable()
        {
            this.id = idCounter++;
            this.address = "";
            this.description = "";
            this.price = 0;
            this.zipCode = 0;
            this.residents = 0;
            this.pets = false;
            this.pool = false;
            this.wifi = false;
            this.occupied = false;
        }
        public Rentable(string address,string description,int zipCode,double price, int residents, bool pets, bool pool,bool wifi)
        {
            this.id = idCounter++;
            this.address = address;
            this.description = description;
            this.zipCode = zipCode;
            this.price = price;
            this.residents = residents;
            this.pets = pets;
            this.pool = pool;
            this.wifi = wifi;
            this.occupied = false;
        }

        public bool Occupied
        {
            get { return occupied; }
            set { occupied = value; }
        }
        public int Id
        {
            get { return id; }
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