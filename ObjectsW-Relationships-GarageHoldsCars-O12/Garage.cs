using System.Collections.Generic;
namespace Garage;
public class FullGarage
{
    List<Car> CarsInGarage = new List<Car>();

    public Car AddCar(Car car)
    //not sure if return Car or return Void method 
    {                       //I really started to see the structure come together
        CarsInGarage.Add(car); //make a new list that conatins 'cars' like a 
                            // string list would hold names, then import the car into
                            //the AddCar method to send it to the CarsInGarage list 
    }

    public void DisplayCars()
    {                       //I really started to see the structure come together
        CarsInGarage.Add(car); //make a new list that conatins 'cars' like a 
                            // string list would hold names, then add 
    }


}