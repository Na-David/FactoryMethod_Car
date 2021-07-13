using System;

namespace Factory_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mention you want car company");
            string CarModel = Console.ReadLine();

            CarFactory carcompany = CarCompany.GetCarModel(CarModel);

            if (CarModel != null)
            {
                Console.WriteLine(" Car Model : {0}", carcompany.GetCarModel());
                Console.WriteLine(" Car Made : {0}", carcompany.GetCarMade());
                Console.WriteLine(" Car Colour : {0}", carcompany.GetCarColour());
            }
        }
    }
}
