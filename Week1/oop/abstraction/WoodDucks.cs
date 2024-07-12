namespace Abstraction;

public class WoodDucks : Duck, IDuck {
    //override abstract method
        public override void Swim(){
            Console.WriteLine("Swimming Fast!");
        }
        public void fly(){
            Console.WriteLine("Fly high!");
        }
}        
