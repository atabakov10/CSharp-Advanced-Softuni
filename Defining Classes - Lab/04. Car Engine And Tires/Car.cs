﻿using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;

        
        public Car()
        {
            this.make = "VW";
            this.model = "Golf";
            this.year = 2025;
            this.fuelQuantity = 200;
            this.fuelConsumption = 10;
        }
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.fuelQuantity = 200;
            this.fuelConsumption = 10;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            this.Engine = engine;
            this.Tires = tires;
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        public void Drive(double distance)
        {
            double consumption = distance * this.FuelConsumption;
            if (consumption <= this.FuelQuantity)
                this.FuelQuantity -= consumption;
            else
                Console.WriteLine("Not enough fuel to perform this trip!");
        }
        public string WhoAmI()
        {
            string carInfo =
                $"Make: {this.Make}\n" +
                $"Model: {this.Model}\n " +
                $"Year: {this.Year}\n" +
                $"Fuel: {this.FuelQuantity:f2}\n";

            return carInfo;
        }

    }
}

