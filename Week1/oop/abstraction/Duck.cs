namespace Abstraction;
public abstract class Duck{
    //can have abstract or non abstract method

        //abstract method
        public abstract void Swim();

        //non abstract method (default)
        public void Quack(){
            Console.WriteLine("Quacking");
        }
}