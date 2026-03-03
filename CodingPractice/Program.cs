using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

// README.md를 읽고 코드를 작성하세요.
//{
//    Console.WriteLine("1-1. 기본 상속 문법");
//
//    Child child = new Child();
//    child.Greet();
//    child.Study();
//}

Console.WriteLine();

//{
//    Console.WriteLine("1-2. 동물 클래스 상속");
//
//    Dog dog = new Dog();
//    dog.Name = "초코";
//    dog.Eat();
//    dog.Bark();
//
//    Cat cat = new Cat();
//    cat.Name = "나비";
//    cat.Eat();
//    cat.Meow();
//}

Console.WriteLine();

{
    Console.WriteLine("2. Object 클래스");

    Product product = new Product { Name = "키보드", Price = 50000 };

    Console.WriteLine(product.ToString());
    Console.WriteLine(product.GetType());
}

Console.WriteLine();

//{
//    Console.WriteLine("3. 접근 제한자와 상속");
//
//    Child child = new Child();
//
//    child.ShowValues();
//    Console.WriteLine(child.PublicValue);
//}

Console.WriteLine();

{
    Console.WriteLine("4. base 키워드");

    Manager manager = new Manager();

    manager.ShowInfo();
}

Console.WriteLine();

{
    Console.WriteLine("5-1. 부모 생성자 호출 (base)");

    Student student = new Student("홍길동", 3);

    student.ShowInfo();
}

Console.WriteLine();

//{
//    Console.WriteLine("5-2. 암시적 기본 생성자 호출");
//
//    Dog dog = new Dog();
//}

Console.WriteLine();

//{
//    Console.WriteLine("6-1. 업캐스팅");
//
//    Dog dog = new Dog { Name = "멍멍이" };
//    Animal animal = dog;
//
//    animal.Eat();
//}

Console.WriteLine();

//{
//    Console.WriteLine("6-2. 다운캐스팅");
//
//    Dog dog = new Dog { Name = "멍멍이" };
//    Animal animal = dog;
//
//    Dog dog2 = (Dog)animal;
//
//    dog2.Bark();
//}

Console.WriteLine();

//{
//    Console.WriteLine("6-3. is 연산자로 타입 검사");
//
//    Animal animal = new Dog { Name = "멍멍이" };
//
//    if (animal is Dog)
//    {
//        Dog dog = (Dog)animal;
//
//        dog.Bark();
//    }
//}

Console.WriteLine();

//{
//    Console.WriteLine("6-4. is 패턴 매칭");
//
//    Animal animal = new Dog { Name = "멍멍이" };
//
//    if (animal is Dog dog)
//    {
//        dog.Bark();
//    }
//}

Console.WriteLine();

//{
//    Console.WriteLine("6-5. as 연산자로 안전한 캐스팅");
//
//    Animal animal = new Cat { Name = "야옹이" };
//
//    Dog dog = animal as Dog;
//
//    if (dog != null)
//    {
//        dog.Bark();
//    }
//    else
//    {
//        Console.WriteLine("Dog 타입이 아닙니다.");
//    }
//}

Console.WriteLine();

{
    Console.WriteLine("7. 다형성");

    Asset[] assets = new Asset[3];

    assets[0] = new Stock { Name = "삼성전자", Shares = 100 };
    assets[1] = new House { Name = "아파트", Mortgage = 300000000 };
    assets[2] = new Stock { Name = "SK하이닉스", Shares = 50 };
}

Console.WriteLine();

{
    Console.WriteLine("8-1. 추상 클래스 기본");

    Rectangle rect = new Rectangle { Name = "사각형", Width = 10, Height = 5 };
    Circle circle = new Circle { Name = "원", Radius = 3 };

    Console.WriteLine($"{rect.Name} 넓이: {rect.GetArea()}");
    Console.WriteLine($"{circle.Name} 넓이: {circle.GetArea():F2}");
}

Console.WriteLine();

{
    Console.WriteLine("8-2. 추상 메서드");

    Car car = new Car();

    car.Start();
    car.Stop();
}

Console.WriteLine();

{
    Console.WriteLine("9. 봉인 클래스");

    FinalClass finalClass = new FinalClass();

    finalClass.Display();
}

Console.WriteLine();

{
    Console.WriteLine("10. 멤버 숨기기 (new 키워드)");

    Child child = new Child();
    Parent parent = child;

    Console.WriteLine($"child.Value: {child.Value}");
    Console.WriteLine($"parent.Value: {parent.Value}");
    
    child.Show();
    parent.Show();
}

Console.WriteLine();

{
    Console.WriteLine("11. is-a 관계");

    Dog dog = new Dog();

    Console.WriteLine(dog is Animal);
    Console.WriteLine(dog is Dog);
    Console.WriteLine(dog is Cat);
}

Console.WriteLine();

{
    Console.WriteLine("12. 종합 예제: 게임 캐릭터 시스템");

    GameCharacter[] characters = new GameCharacter[]
    {
        new Warrior("아서", 25),
        new Mage("멀린", 40),
        new Warrior("란슬롯", 30)
    };

    foreach (GameCharacter character in characters)
    {
        character.ShowStatus();
        character.Attack();
        Console.WriteLine();
    }
}
