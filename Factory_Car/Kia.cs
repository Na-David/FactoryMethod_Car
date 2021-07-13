using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Car
{
    public class Kia : CarFactory
    {
        public string GetCarColour()
        {
            return "Silver";
        }
        public string GetCarModel()
        {
            return "K5";
        }
        public int GetCarMade()
        {
            return 2018;
        }

    }
}
