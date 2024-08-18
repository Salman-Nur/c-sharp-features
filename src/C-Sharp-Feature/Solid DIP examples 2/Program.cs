//4 spaceship has 4 type of Engine. Boost the power of Turbo engine, Electric engine, Fuel Cell engine,
//Hybrid engine by 10% , 20% , 30% , 40%  respectively and print the all engine power after encreasing.

/// High-level modules should not depend on low-level modules. Both high and low level module should depend on
/// abstractions and those abstraction should not depend on details.


using Solid_DIP_examples_2;

SpaceShip spaceShip1 = new SpaceShip(new TurboEngine());
spaceShip1.InitializeEngine();
spaceShip1.CurrentPower = spaceShip1.Engine.InitializedPower;
spaceShip1.BoostPower(10);
Console.WriteLine("After Boosting, Spaceship Engine Power is: " + spaceShip1.CurrentPower + " MW");

SpaceShip spaceShip2 = new SpaceShip(new ElectricEngine());
spaceShip2.InitializeEngine();
spaceShip2.CurrentPower = spaceShip2.Engine.InitializedPower;
spaceShip2.BoostPower(20);
Console.WriteLine("After Boosting, Spaceship Engine Power is: " + spaceShip2.CurrentPower + " MW");

SpaceShip spaceShip3 = new SpaceShip(new FuelCellEngine());
spaceShip3.InitializeEngine();
spaceShip3.CurrentPower = spaceShip3.Engine.InitializedPower;
spaceShip3.BoostPower(30);
Console.WriteLine("After Boosting, Spaceship Engine Power is: " + spaceShip3.CurrentPower +" MW");

SpaceShip spaceShip4 = new SpaceShip(new HybridEngine());
spaceShip4.InitializeEngine();
spaceShip4.CurrentPower = spaceShip4.Engine.InitializedPower;
spaceShip4.BoostPower(40);
Console.WriteLine("After Boosting, Spaceship Engine Power is: " + spaceShip4.CurrentPower +" MW");

