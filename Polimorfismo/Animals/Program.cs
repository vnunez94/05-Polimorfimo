using System;
class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Dog();
        animal.Eat();

        animal = new Cat();
        animal.Eat();

        animal = new Bird();
        animal.Eat();

    }

}

public class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dog is eating.");
    }
}

public class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cat is eating.");
    }
}

public class Bird : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Bird is eating.");
    }
}


