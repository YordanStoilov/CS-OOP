namespace Farm;

public class StartUp
{
    static void Main()
    {
        Dog dog = new Dog();
        Animal animal = new Animal();
        Puppy puppy = new Puppy();
        puppy.Weep();
        puppy.Bark();
        puppy.Weep();
    }
}