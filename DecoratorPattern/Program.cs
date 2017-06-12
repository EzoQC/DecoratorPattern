using System;

/**
 * Code source de l'article http://blog.ezoqc.com/patron-de-conception-decorateur/
 * (C) Ezo Inc. - Tous droits réservés - 2017
 **/
namespace com.ezoqc.blog.designpatterns.decorator
{
  public class Program
  {
    public static void Main(string[] args)
    {
      SomeBusinessObject logic = new ConcreteBusinessObjectLoggingDecorator()
      {
        Target = new ConcreteBusinessObject()
      };

      logic.Do("something");
    }
  }


  interface SomeBusinessObject
  {
    string Do(string what);
  }

  class ConcreteBusinessObject : SomeBusinessObject
  {
    public string Do(string what)
    {
      string outputString = "I just did this: " + what;

      return outputString;
    }
  }

  class ConcreteBusinessObjectLoggingDecorator : SomeBusinessObject
  {
    public ConcreteBusinessObject Target { get; set; }

    public string Do(string what)
    {
      Console.WriteLine("ConcreteBusinessObjectLoggingDecorator:Do(string what)");
      Console.WriteLine("what=" + what);

      string result = Target.Do(what);

      Console.WriteLine("result=" + result);

      return result;
    }
  }
}