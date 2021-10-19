using System;

namespace Лабараторна_4._1
{
    class ColorWhite
    {
        public virtual void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(value);
        }
 
    }
 
    class ColorGreen : ColorWhite
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
        }
    }
 
    class ColorRed : ColorWhite
    {
        public new void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }
 
    }
 
    class Program
    {
        private static void Main(string[] args)
        {
            var arr = new ColorWhite[3];
            arr[0] = new ColorWhite();
            arr[1] = new ColorRed();
            arr[2] = new ColorGreen();

           
            ((ColorWhite)arr[0]).Print("White");
            ((ColorRed)arr[1]).Print("Red");
            ((ColorGreen)arr[2]).Print("Blue");

        }

    }
}
