using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Car
{
    class CarCompany
    {
        public static CarFactory GetCarModel(string CarModel)
        {
            CarFactory carCompany = null;

            switch (CarModel)
            {
                case "Kia":
                    carCompany = new Kia();
                    break;
                case "Hyundai":
                    carCompany = new Hyundai();
                    break;
                case "Ssangyoung":
                    carCompany = new Ssangyoung();
                    break;
            }

            return carCompany;
        }
    }
}
