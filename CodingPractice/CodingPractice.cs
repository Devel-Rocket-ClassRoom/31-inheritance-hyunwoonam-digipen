using System;
using System.Collections.Generic;
using System.Text;

//public class Parent
//{
//    public void Greet()
//    {
//        Console.WriteLine("안녕하세요!");
//    }
//}
//
//public class Child : Parent
//{
//    public void Study()
//    {
//        Console.WriteLine("공부합니다.");
//    }
//}

//public class Animal
//{
//    public string Name;
//
//    public void Eat()
//    {
//        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
//    }
//}
//
//public class Dog : Animal
//{
//    public void Bark()
//    {
//        Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
//    }
//}
//
//public class Cat : Animal
//{
//    public void Meow()
//    {
//        Console.WriteLine($"{Name}이(가) 야옹 웁니다.");
//    }
//}

public class Product
{
    public string Name;
    public int Price;
}

//public class Parent
//{
//    private int PrivateValue = 1;
//    protected int ProtectedValue = 2;
//    public int PublicValue = 3;
//}
//
//public class Child : Parent
//{
//    public void ShowValues()
//    {
//        Console.WriteLine(ProtectedValue);
//        Console.WriteLine(PublicValue);
//    }
//}

public class Employee
{
    protected string _department = "개발팀";

    public void ShowDepartment()
    {
        Console.WriteLine($"부서: {_department}");
    }
}

public class Manager : Employee
{
    public void ShowInfo()
    {
        Console.WriteLine($"소속 부서: {base._department}");

        base.ShowDepartment();
    }
}

public class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"Person 생성자 호출: {Name}");
    }
}

public class Student : Person
{
    public int Grade;

    public Student(string name, int grade) : base(name)
    {
        Grade = grade;
        Console.WriteLine($"Student 생성자 호출: {Grade}학년");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"이름: {Name}, 학년: {Grade}");
    }
}

//public class Animal
//{
//    public Animal()
//    {
//        Console.WriteLine("Animal 기본 생성자");
//    }
//}
//
//public class Dog : Animal
//{
//    public Dog()
//    {
//        Console.WriteLine("Dog 생성자");
//    }
//}

//public class Animal
//{
//    public string Name;
//
//    public void Eat()
//    {
//        Console.WriteLine($"{Name}이(가) 먹습니다.");
//    }
//}
//
//public class Dog : Animal
//{
//    public void Bark()
//    {
//        Console.WriteLine($"{Name}이(가) 짖습니다.");
//    }
//}
//
//public class Cat : Animal
//{
//}
//
public class Asset
{
    public string Name;
}

public class Stock : Asset
{
    public int Shares;
}

public class House : Asset
{
    public decimal Mortgage;
}

public abstract class Shape
{
    public string Name;
    public abstract double GetArea();
}

public class Rectangle : Shape
{
    public double Width;
    public double Height;

    public override double GetArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius;

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public abstract class Vehicle
{
    public abstract void Start();

    public void Stop()
    {
        Console.WriteLine("정지합니다.");
    }
}

public class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("자동차 시동을 켭니다.");
    }
}

sealed class FinalClass
{
    public void Display()
    {
        Console.WriteLine("이 클래스는 상속할 수 없습니다.");
    }
}

public class Parent
{
    public int Value = 10;

    public void Show()
    {
        Console.WriteLine("Parent.Show()");
    }
}

public class Child : Parent
{
    public new int Value = 20;

    public new void Show()
    {
        Console.WriteLine("Child.Show()");
    }
}

public class Animal
{
}

public class Dog : Animal
{
}

public class Cat : Animal
{
}

public abstract class GameCharacter
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }

    protected GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void Attack();

    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] 체력: {Health}");
    }
}

public class Warrior : GameCharacter
{
    public int Strength { get; private set; }

    public Warrior(string name, int strength) : base(name, 150)
    {
        Strength = strength;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 검으로 {Strength} 데미지를 입힙니다!");
    }
}

public class Mage : GameCharacter
{
    public int MagicPower { get; private set; }

    public Mage(string name, int magicPower) : base(name, 80)
    {
        MagicPower = magicPower;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 마법으로 {MagicPower} 데미지를 입힙니다!");
    }
}
