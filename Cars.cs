using System;
using System.Collections.Generic;

class Car
{
  private string MakeModel;
  private int Price;
  private int Miles;

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (Price <= maxPrice && Miles <= maxMiles);
  }

  public Car(string carModel = "used car", int carPrice = 10000, int carMiles = 5000)
  {
    MakeModel = carModel;
    Price = carPrice;
    Miles = carMiles;
  }

  public string GetModel()
  {
    return MakeModel;
  }

  public int GetPrice()
  {
    return Price;
  }

  public int GetMiles()
  {
    return Miles;
  }

  public void SetModel(string carModel)
  {
    MakeModel = carModel;
  }

  public void SetPrice(int carPrice)
  {
    Price = carPrice;
  }

  public void SetMiles(int carMiles)
  {
    Miles = carMiles;
  }
}

public class Program
{
  public static void Main()
  {
    Car bmw = new Car("BMW M4", 60000, 15000);
    Car mercedes = new Car("S63 AMG", 85000);
    Car used = new Car();
    mercedes.SetMiles(6500);
    mercedes.SetModel("G55 AMG");
    Console.WriteLine(bmw.GetModel());
    Console.WriteLine(bmw.GetPrice());
    Console.WriteLine(bmw.GetMiles());
    Console.WriteLine(mercedes.GetModel());
    Console.WriteLine(mercedes.GetPrice());
    Console.WriteLine(mercedes.GetMiles());
    Console.WriteLine(used.GetModel());
    Console.WriteLine(used.GetPrice());
    Console.WriteLine(used.GetMiles());


    List<Car> Cars = new List<Car>() {bmw, mercedes, used };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    if (CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine("Criteria does not match");
    } else
    {
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.GetModel());
      }
    }
  }
}
