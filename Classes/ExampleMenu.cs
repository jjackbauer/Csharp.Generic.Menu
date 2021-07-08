using System;
namespace Generic.Menu
{
    public class ExampleMenu : Menu
    {
        public ExampleMenu()
        {
            Headers.Add("Generic Menu Demo");
            Headers.Add("Developed by Ricardo Medeiros");
            Headers.Add("https://github.com/jjackbauer/Csharp.Generic.Menu");

            Options.Add(setOption("func1",'1',true,func1));
            Options.Add(setOption("func2",'2',true,func2));
            Options.Add(setOption("func3",'3',true,func3));
            Options.Add(setOption("Clear Screen",'C',true,Clear));   
        }
        
        static void func1()
        {
            //Do something...
            Console.WriteLine(nameof(func1));
        }
        static void func2()
        {
            //Do something...
            Console.WriteLine(nameof(func2));
        }
        static void func3()
        {
            //Do something...
            Console.WriteLine(nameof(func3));
        }

    }


}