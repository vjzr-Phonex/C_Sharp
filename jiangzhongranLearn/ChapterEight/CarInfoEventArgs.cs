﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterEight
{
    public class CarInfoEventArgs : EventArgs
    {
        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }

        public string Car { get;private set; }
    }

    public class CarDealer
    { 
        public event EventHandler<CarInfoEventArgs> NewCarInfo;

        public void NewCar(string car)
        {
            Console.WriteLine("CarDealer,new car {0}",car);
            if(NewCarInfo != null)
            {
                NewCarInfo(this,new CarInfoEventArgs(car));
            }
        }
    }
}
