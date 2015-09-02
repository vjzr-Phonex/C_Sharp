using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterEight
{
    class Heater
    {
        private int temperature;
        public delegate void BoilHandler(int param);
        public event BoilHandler BoilEvent;

        public void BoilWater()
        {
            for (int i = 0; i <= 100;i++ )
            {
                temperature = i;

                if(temperature > 95)
                {
                    if (BoilEvent != null)
                    {
                        BoilEvent(temperature);
                    }
                }
            }
        }
    }

    public class Alarm
    {
        public void MakeAlert(int param)
        {
            Console.WriteLine("Alarm: the water's temperature is {0}",param);
        }
    }

    public class Display
    {
        public static void ShowMsg(int param)
        {
            Console.WriteLine("Display: the water is nearly boiled!!! @ {0} temperature!",param);
        }
    }

}
