using System;

// Base Animal Class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("I can eat!");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("I make a sound.");
    }
}

// Dog Class inheriting from Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("I can bark!");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");  // Override the base class sound
    }
}

// Cat Class inheriting from Animal
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("I can meow!");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow! Meow!");
    }
}

// Bird Class inheriting from Animal
class Bird : Animal
{
    public void Chirp()
    {
        Console.WriteLine("I can chirp!");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Tweet! Tweet!");
    }
}

// Fish Class inheriting from Animal
class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine("I can swim!");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Blub blub!");  // Fish don't really make sound, but we give it a sound.
    }
}

// Elephant Class inheriting from Animal
class Elephant : Animal
{
    public void Trumpet()
    {
        Console.WriteLine("I can trumpet!");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Pawoo! Pawoo!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create objects of each animal
        Dog dog = new Dog();
        Console.WriteLine("Dog:");
        dog.Eat();
        dog.Bark();
        dog.MakeSound();  // Calling overridden method
        Console.WriteLine();

        Cat cat = new Cat();
        Console.WriteLine("Cat:");
        cat.Eat();
        cat.Meow();
        cat.MakeSound();
        Console.WriteLine();

        Bird bird = new Bird();
        Console.WriteLine("Bird:");
        bird.Eat();
        bird.Chirp();
        bird.MakeSound();
        Console.WriteLine();

        Fish fish = new Fish();
        Console.WriteLine("Fish:");
        fish.Eat();
        fish.Swim();
        fish.MakeSound();
        Console.WriteLine();

        Elephant elephant = new Elephant();
        Console.WriteLine("Elephant:");
        elephant.Eat();
        elephant.Trumpet();
        elephant.MakeSound();
    }
}
