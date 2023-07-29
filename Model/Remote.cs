using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace DogDoorApp.Model
{
    internal class Remote
    {
     
        private DogDoor _door;
        static Timer Timer;
        public Remote(DogDoor door) 
        { 
            _door = door;
        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button....");
            if(_door.IsOpen())
            {
                _door.Close();
            }
            else {
                _door.Open();


               
             
            }
        }

        public void AutoClose()
        {
            Thread.Sleep(1000);
            _door.Close();  

        }
    }
}
