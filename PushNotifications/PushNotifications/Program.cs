using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PushNotifications.IOS;

namespace PushNotifications
{
    class Program
    {
        static void Main(string[] args)
        {            
            IOSTimer.Start();

            Console.WriteLine("Press enter to stop service.");
            Console.ReadLine();
        }
    }
}
