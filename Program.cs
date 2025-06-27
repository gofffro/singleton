using System;

namespace singleton
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Singleton singleton = Singleton.GetInstance();
      singleton.SayHello();
    }
  }

  public class Singleton
  {
    private static readonly Singleton instance = new Singleton();

    private Singleton() { }

    public static Singleton GetInstance()
    {
      return instance;
    }

    public void SayHello()
    {
      Console.WriteLine("Привет из Singleton!");
    }
  }
}
