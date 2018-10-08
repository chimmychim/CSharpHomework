using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
     class Clock
    {
         int hour, min, sec;
         int hour2, min2, sec2;
        public event EventHandler ring;
        protected virtual void OnRing()
        {
            EventHandler temp = ring;
            if (temp != null) temp(this,EventArgs.Empty);
        }
        public void setTime(int hour,int min,int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
         public void setClock(int hour,int min,int sec)
         {
             this.hour2 = hour;
             this.min2 = min;
             this.sec2 = sec;
         }
         public void checkClock()
         {
             if ((sec == sec2) && (min == min2) && (hour == hour2))
             {
                 Console.WriteLine("生日快乐！");
                 OnRing(); 
             }
         }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();
            myClock.setTime(10, 13, 0);
            myClock.setClock(10, 13, 0);
            myClock.checkClock(); 
        }
    }  
}


