﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3InheritancePolymorphism
{
    class Vehicle
    {

        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        private float gearRatio;
        private float engineSize;
        private double distanceTraveled;

        public int Seats
        {
            get { return this.seats; }
        }

        public int CarryingCapicity
        {
            get { return this.carryingCapacity; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }

        public Vehicle()
        {

        }


        //Constructors

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
          this.seats = seats;
            this.carryingCapacity = carryingCapacity;
          this.color = color;
          this.movementSpeed = movementSpeed;
          this.distanceTraveled = 0.0d;
         }

        public void Move()
        {
            distanceTraveled += movementSpeed;
        }











    }
}
