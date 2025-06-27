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
    private static readonly Singleton _instance = new Singleton();

    private Singleton() { }

    public static Singleton GetInstance()
    {
      return _instance;
    }

    public void SayHello()
    {
      Console.WriteLine("123");
    }
  }
}
