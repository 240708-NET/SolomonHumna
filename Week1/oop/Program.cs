/*using Inheritance namespace
WoodDucks myDuck = new WoodDucks();

myDuck.Swim();*/

/*using Polymorphism;

WoodDucks myWoodDuck = new WoodDucks();
//overriding
myWoodDuck.Swim();

//overloading
myWoodDuck.fly();
myWoodDuck.fly(3);
myWoodDuck.fly(Rex);*/

using Abstraction;

RubberDuck dean = new RubberDuck();
WoodDucks sam = new WoodDucks();

dean.Swim();
sam.fly();
sam.Swim();

