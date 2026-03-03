using System;
using System.Collections.Generic;
using System.Text;

public class Animal
{
    public string Name { get; }
    private int Age;

    protected string _sound;

    public Animal(string name, int age, string sound)
    {
        Name = name;
        Age = age;
        _sound = sound;
    }

    public void Eat()
    {
        Console.WriteLine("먹이를 먹습니다");
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name}: {_sound}");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"이름: {Name}, 나이: {Age}살");
    }
}

public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age, "으르렁!")
    {
    }


    public void Hunt()
    {
        Console.WriteLine("사냥을 합니다");
    }
}

public class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age, "뿌우!")
    {
    }


    public void SprayWater()
    {
        Console.WriteLine("물을 뿌립니다");
    }
}

public class Penguin : Animal
{
    public Penguin(string name, int age) : base(name, age, "꽥꽥!")
    {
    }


    public void Swim()
    {
        Console.WriteLine("수영을 합니다");
    }
}