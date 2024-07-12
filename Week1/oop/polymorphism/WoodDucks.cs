namespace Polymorphism;
public class WoodDucks : Duck{  // this is like extends in java

    //overriding
    public override void Swim(){
        Console.WriteLine("Walking!");
    }

    //overloading
    public void fly(){
        Console.WriteLine("Fly!");
    }
    public void fly(int num){
        for(int i = 0; i < num; i++){
            Console.WriteLine("Fly!");
        }
    }
    public void fly(string name){
        Console.WriteLine(name);
    }
}