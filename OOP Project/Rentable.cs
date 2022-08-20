using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Project
{
    public abstract class Rentable
    {
        private string address;
        private string description;
        private int zipCode;
        private double price;
        private int residents;
        private bool pets;
        private bool occupied;

        public Rentable()
        {
            this.address = "";
            this.price = 0;
            this.zipCode = 0;
            this.residents = 0;
            this.pets = false;
        }
        Rentable(string address,int zipCode,double price, int residents, bool pets)
        {
            this.address = address;
            this.zipCode = zipCode;
            this.price = price;
            this.residents = residents;
            this.pets = pets;
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

    }
}