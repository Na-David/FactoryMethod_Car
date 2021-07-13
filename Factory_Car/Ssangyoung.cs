using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Car
{
    public class Ssangyoung : CarFactory
    {
        public string GetCarColour()
        {
            return "RED";
        }
        public string GetCarModel()
        {
            return "Tivoli";
        }
        public int GetCarMade()
        {
            return 2020;
        }
    }
}
