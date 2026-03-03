using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    protected string _name;
    protected int _baseSalary;

    public Employee(string name, int baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
    }

    public string GetName()
    {
        return _name; 
    }

    public int GetBaseSalary()
    {
        return _baseSalary;
    }

    public int CalculatePay()
    {
        return _baseSalary; 
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{_name}");
    }
}

public class Manager : Employee
{
    private string _name;
    private int _baseSalary;
    private int _bonus;

    public Manager(string name, int baseSalary, int bonus) : base(name, baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
        _bonus = bonus;
    }

    public new int CalculatePay()
    {
        return _baseSalary + _bonus;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[매니저] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"보너스: {_bonus:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}

public class Developer : Employee
{
    private string _name;
    private int _baseSalary;
    private int _overtimeHours;

    public Developer(string name, int baseSalary, int overtimeHours) : base(name, baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
        _overtimeHours = overtimeHours;
    }

    public new int CalculatePay()
    {
        return _baseSalary + (_overtimeHours * 20000);
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[개발자] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"초과근무: {_overtimeHours}시간");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}

public class Intern : Employee
{
    private string _name;

    public Intern(string name) : base(name, 1500000)
    {       
        _name = name;
    }

    public new int CalculatePay()
    {
        return base._baseSalary;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[인턴] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}