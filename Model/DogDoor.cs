﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
    internal class DogDoor
    {
        private bool _open;
        public DogDoor()
        {
            _open = false;
        }
        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            _open=true;
        }
        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            _open = false;
        }
        public bool IsOpen()
        {
            return _open;
        }
    }
}
