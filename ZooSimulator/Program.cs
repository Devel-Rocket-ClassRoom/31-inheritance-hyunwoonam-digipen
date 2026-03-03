using System;
using System.Xml.Linq;

// README.md를 읽고 코드를 작성하세요.
Lion l = new Lion("시바", 5);
Elephant e = new Elephant("덤보", 10);
Penguin p = new Penguin("뽀로로", 3);

Console.WriteLine("[동물 정보]");
l.DisplayInfo();
e.DisplayInfo();
p.DisplayInfo();

Console.WriteLine("\n[동물 소리]");
l.MakeSound();
e.MakeSound();
p.MakeSound();

Console.WriteLine("\n[동물 행동]");

Console.Write($"{l.Name}이(가) ");
l.Eat();
Console.Write($"{l.Name}이(가) ");
l.Hunt();
Console.Write($"{e.Name}이(가) ");
e.Eat();
Console.Write($"{e.Name}이(가) ");
e.SprayWater();
Console.Write($"{p.Name}이(가) ");
p.Eat();
Console.Write($"{p.Name}이(가) ");
p.Swim();