using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_task
{
    // this code is from my solution of https://exercism.org/tracks/csharp/exercises/clock
    public class Clock
    {
        int Hours, Minutes;
        public Clock(int hours, int minutes)
        {
            int allMinutes = hours * 60 + minutes;
            if (allMinutes >= 0)
            {
                Minutes = allMinutes % 60;
                if (allMinutes / 60 < 24)
                {
                    Hours = allMinutes / 60;
                }
                else
                {
                    Hours = (allMinutes / 60) % 24;
                }
            }
            else
            {
                int addedhrs = -allMinutes / 60 + 1;
                if (allMinutes % 60 == 0)
                {
                    Minutes = 0;
                    addedhrs--;
                }
                else
                {
                    Minutes = 60 + allMinutes % 60;
                }


                if (addedhrs < 24 && addedhrs % 24 != 0)
                {
                    Hours = 24 - addedhrs;
                }
                else if (addedhrs % 24 == 0)
                {
                    Hours = 0;
                }
                else
                {
                    Hours = 24 - (addedhrs % 24);
                }
            }
        }

        public Clock Add(int minutesToAdd)
        {

            int minutes = (minutesToAdd + Minutes) % 60;
            int hrs = (Minutes + minutesToAdd) / 60 + Hours;

            Clock clock = new Clock(hrs, minutes);
            return clock;
        }

        public Clock Subtract(int minutesToSubtract)
        {

            int minutes = (Minutes - minutesToSubtract) % 60;
            int hrs = (Minutes - minutesToSubtract) / 60 + Hours;

            Clock clock = new Clock(hrs, minutes);
            return clock;
        }

        public int GetMinutes()
        {
            return Minutes;
        }
        public int GetHours()
        {
            return Hours;
        }
        public override string ToString()
        {
            return String.Format("{0:00}:{1:00}", Hours, Minutes);
        }
        public override bool Equals(object? obj)
        {
            return obj is Clock clock &&
                   Hours == clock.Hours &&
                   Minutes == clock.Minutes;
        }
    }
}
