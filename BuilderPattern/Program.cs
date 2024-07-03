using BuilderPattern;

Console.WriteLine("***Builder Pattern Demo***");

Director director = new Director();

IBuilder car = new Car("Ford");
IBuilder motorcycle = new MotorCycle("Honda");

// Making Car
director.Construct(car);

Product carProduct = car.GetVehicle();
carProduct.Show();

//Making MotorCycle
director.Construct(motorcycle);

Product motorCycleProduct = motorcycle.GetVehicle();
motorCycleProduct.Show();


Console.ReadLine();