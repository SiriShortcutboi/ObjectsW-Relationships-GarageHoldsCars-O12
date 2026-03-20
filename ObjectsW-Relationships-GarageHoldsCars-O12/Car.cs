//namespace CoolCarSpace;

//note if you are using namespaces, remember method.this.that calls the name
// of the namespace, not the name of the file e.g. CoolCarSpace not Car.cs
public class CarClass
{
    public string Model;

    public Car(string model) //you're calling the names of the generic Car attributes
    {                       // and equaling them to the New lowercase car-instance,
                            //you're making a new one locally, thus separately
        Model = model;
    }

}