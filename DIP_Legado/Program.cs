using System;
using SOLID_DIP;
using SOLID_DIP;
using DIP_Legado;

namespace SOLID_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            IDispositivo lamp = new Lamp(State.Off);

            Switch sw = new Switch(lamp);


            sw.Press();
            sw.Press();
        }
    }
}

