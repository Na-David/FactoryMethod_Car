using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Car
{
    public interface CarFactory
    {
        public string GetCarColour();
        public string GetCarModel();
        public int GetCarMade();
    }
}
