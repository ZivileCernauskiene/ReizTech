using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_task
{
    internal static class clockAngleTask
    {
        
        public static double CalculateAngle(Clock clock)
        {
            int minutes = clock.GetMinutes();
            int hours=clock.GetHours();
             
            double hourAngle = (hours * 60 + minutes) * 0.5;
            double minuteAngle=minutes * 6;

            int angle;
            if (hourAngle >= minuteAngle)
            {
               
                angle = (int)(hourAngle - minuteAngle);
                
            }
            else
            {
                angle = (int)(minuteAngle - hourAngle);
                
            }
            if (angle >= 360)
            {
                angle -= 360;
            }
            
            return Math.Min(angle, 360 - angle);
        }
    }
}
