using System;
class Program
{
    void sum(int a, int b)
    {
        Console.WriteLine("adding int a&b is :"+(a+b));
    }
    void sum(double a, double b,double c)
    {
      Console.WriteLine("adding double a&b :"+(a+b+c));    
    }
  static void Main() 
  {
    Program summ = new Program();
    summ.sum(1,9);
    summ.sum(3.2, 4.8,5.1);
  }
}