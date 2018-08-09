using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Smartphone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public CommunicationStandard CS { get; set; }
        public Display D { get; set; }
        public SIM_Carts SIM { get; set; }
        public Memory M { get; set; }
        /*public OS OS { get; set; }
        public Camera Cam { get; set; }
        public CPU cpu { get; set; }
        public Power Pow { get; set; }
        public Mateial Mat { get; set; }
        public Connectors Conn { get; set; }
        public Navigation Nav { get; set; }
        public Dimensions Dim { get; set; }
        public FM_Radio FM { get; set; }
        public Wireless Wir { get; set; }
        public Other Oth { get; set; }
        public Reviews Rev { get; set; }*/
    }

    class CommunicationStandard
    {
        public int Id { get; set; }
        //public List<string> Standarts { get; set; }
        //????????????????????????????????
    }

    class Display
    {
     

        public int Id { get; set; }
        public float Diagonal { get; set; }
        public int DisplayResolutionX { get; set; }
        public int DisplayResolutionY { get; set; }
        public string TypeOfMatrix { get; set; }
        public string IPS { get; set; }
        public string NumberOfTouchPoints { get; set; }
        public string ScreenMaterial { get; set; }

        Display()
        {
            Id = 1;
            Diagonal = 8;
            DisplayResolutionX = 5;
            DisplayResolutionY = 7;
        }
}

    class SIM_Carts
    {
        public int Id { get; set; }
        public int NumberOfCarts { get; set; }
        public string Size { get; set; }

        SIM_Carts()
        {
            Id = 1;
        }
    }

    class Memory
    {
        public int Id { get; set; }

        Memory()
        {
            Id = 1;
        }
    }

   /* class OS
    {
        public int Id { get; set; }
    }

    class Camera
    {
        public int Id { get; set; }
    }

    class CPU
    {
        public int Id { get; set; }
    }

    class Power
    {
        public int Id { get; set; }
    }

    class Mateial
    {
        public int Id { get; set; }
    }

    class Connectors
    {
        public int Id { get; set; }
    }

    class Navigation
    {
        public int Id { get; set; }
    }

    class Dimensions
    {
        public int Id { get; set; }
    }

    class FM_Radio
    {
        public int Id { get; set; }
    }

    class Wireless
    {
        public int Id { get; set; }
    }

    class Other
    {
        public int Id { get; set; }
    }

    class Reviews
    {
        public int Id { get; set; }
    }*/
}
