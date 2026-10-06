using Zadacha2;

Rectangle rectangle1 = new Rectangle();
Console.WriteLine("Площ на правоъгълник 1: " + rectangle1.Area());

Rectangle rectangle2 = new Rectangle(5, 4);
Console.WriteLine("Площ на правоъгълник 2: " + rectangle2.Area());

Circle circle1 = new Circle();
Console.WriteLine("Площ на кръг 1: " + circle1.Area());

Circle circle2 = new Circle(3);
Console.WriteLine("Площ на кръг 2: " + circle2.Area());

Console.ReadKey();
