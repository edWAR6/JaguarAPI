using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushNotifications.IOS
{
    class IOSTimer
    {
        private static System.Timers.Timer mainTimer;

        public static void Start()
        {
            mainTimer = new System.Timers.Timer(1);
            mainTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimeEvent);
            mainTimer.Interval =20000;
            mainTimer.Enabled = true;            
        }

        private static void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Event received at {0}", e.SignalTime);
        }
    }
}
