﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
    public class Car
    {
        public Car()
        {
        }

        public string Make{ get; set; }
        public string Model{ get; set; }
        public int Year { get; set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}
