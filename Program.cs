using DogDoorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Timers;
using Timer = System.Timers.Timer;

namespace Doug_sDogDoorApp
{
    internal class Program
    {

        static Timer Timer;
        static void Main(string[] args)
        {

            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside....");
            remote.PressButton();
            Console.WriteLine("Fido has gone outside....");
         
            Console.WriteLine("Fido is all done....");
          
            Console.WriteLine("Fido is back inside....");
            remote.AutoClose();


        }
      
    }
}
