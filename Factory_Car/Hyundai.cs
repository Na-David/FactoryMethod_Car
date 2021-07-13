using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Car
{
    public class Hyundai:CarFactory
    {
        public string GetCarColour()
        {
            return "Grey";
        }
        public string GetCarModel()
        {
            return "SM6";
        }
        public int GetCarMade()
        {
            return 2019;
        }

    }
}
