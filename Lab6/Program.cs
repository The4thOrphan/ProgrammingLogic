using System;

class Car
{
  public string model;
  public string color;
  public int year;

  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }
//Part 1
  public void Start()
  {
    Console.WriteLine("The car is starting.");
  }
//Part 2
  public void Drive(int miles)
  {
    Console.WriteLine($"The car drove {miles} miles.");
  }
//Part 3
  public string GetDescription()
  {
    return $"{year} {color} {model}";
  }

  public void Repaint(string newColor)
  {
    color = newColor;
    Console.WriteLine($"The car has been repainted to {color}.");
  }
}
//Part 4
class Program
{
  static void Main()
  {
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display();
    myCar.Start();
    myCar.Drive(50);
    
    string description = myCar.GetDescription();
    Console.WriteLine(description);

    myCar.Repaint("Red");
    Console.WriteLine(myCar.color);
  }
}