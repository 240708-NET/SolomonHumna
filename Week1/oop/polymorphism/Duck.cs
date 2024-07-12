namespace Polymorphism;
public class Duck{
        public string wings {get; set;}
        public int weight {get; set;}

//virtual word allow us to override the parent class (Methd overriding)
        public virtual void Swim(){
            System.Console.WriteLine("Swimming");
        }

        public void Quack(){
            System.Console.WriteLine("Quacking");
     }
}
