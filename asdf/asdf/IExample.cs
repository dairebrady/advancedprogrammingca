using System;
namespace asdf
{
    public abstract class Example                   // Base class
    {
        public int NumValue { get; set; }

        public abstract void PrintTemperature();        //Abstract method
    }

    public class ColdTemp : Example                 // Sub class 1
    {
        public override void PrintTemperature()
        {
            Console.WriteLine("It is 5 degrees");       // Overridden method
        }                                               // for cold class
    }

    public class HotTemp : Example                  // Sub class 2
    {
        public override void PrintTemperature()
        {
            Console.WriteLine("It is 30 degrees");      // Overridden method
        }                                               // for hot class
    }
}
