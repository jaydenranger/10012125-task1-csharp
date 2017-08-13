using System;

namespace task1C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to convert Celsius to fahrenheit or fahrenheit to celcius? enter C for celsius or F for fahrenheit");
            var Input = Console.ReadLine();
            var C = "C";
            var F = "F";

            if(Input == C)
            {
                Console.WriteLine("enter the number you want to convert to celcius");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Your answer in celcius is " + num1*9/5+32 );


            } else if(Input == F)
            {
              Console.WriteLine("enter the number you want to convert to Fahrenheit");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Your answer in Fahrenheit is " + (num1-32*5/9));

            }



        }
    }
}
