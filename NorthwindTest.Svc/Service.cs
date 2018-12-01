using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindTest.Svc
{
    public class Service
    {
        public bool Start()
        {
            Console.WriteLine("Service started...");
            return true;
        }

        public bool Stop()
        {
            return true;
        }

        public bool Pause()
        {
            Console.WriteLine("Service paused...");
            return true;
        }

        public bool Continue()
        {
            Console.WriteLine("Service continued...");
            return true;
        }
    }
}
