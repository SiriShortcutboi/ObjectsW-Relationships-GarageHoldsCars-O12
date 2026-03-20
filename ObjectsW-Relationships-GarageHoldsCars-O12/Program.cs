using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Garage garage = new Garage(); 

		Car car1 = new Car();
		Car car2 = new Car();

		
		AddCar(Car.car1);
		AddCar(Car.car2);
		
		DisplayCars();
	}
}