using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string userChoice;

            int x;
            double input;
            do
            {
                string responseSecond = string.Empty;
                Console.WriteLine("\n Select option from below:");
                Console.WriteLine("1.Celcius to Fahrenheit");
                Console.WriteLine("2.Celcius to Kelvin");
                Console.WriteLine("3.Fahrenheit to Kelvin");
                Console.WriteLine("4.Fahrenheeit to Celcius");
                Console.WriteLine("5.Kelvin to Fahrenheit");
                Console.WriteLine("6.Kelvin to Celcius");
                Console.WriteLine("7.Exit");

                userChoice = string.Empty;


                do
                {
                    Console.Write("select option  from 1 to 7: ");
                    userChoice = Console.ReadLine();
                } while (!int.TryParse(userChoice, out x) || (x < 1) || (x > 7));



                double convertedValue;
                switch (x)
                {

                    case 1:
                        Console.WriteLine("Enter Celcius Value to convert into Fahrenheit");
                        input = double.Parse(Console.ReadLine());
                        Conversion c1 = new Conversion(input);
                        convertedValue = c1.ConvertCelciusToFahrenheit();
                        Console.WriteLine(convertedValue + " Fahrenheit");
                        break;

                    case 2:
                        Console.WriteLine("Enter Celcius Value to convert into Kelvin");
                        input = double.Parse(Console.ReadLine());
                        Conversion c2 = new Conversion(input);
                        convertedValue = c2.ConvertCelciusToKelvin();
                        Console.WriteLine(convertedValue + " Kelvin");
                        break;

                    case 3:
                        Console.WriteLine("Enter Fahrenheeit Value to convert into Kelvin");
                        input = double.Parse(Console.ReadLine());
                        Conversion c3 = new Conversion(input);
                        convertedValue = c3.ConvertFahrenheitToKelvin();
                        Console.WriteLine(convertedValue + " Kelvin");
                        break;

                    case 4:
                        Console.WriteLine("Enter Fahrenheit Value to convert into Celcius");
                        input = double.Parse(Console.ReadLine());
                        Conversion c4 = new Conversion(input);
                        convertedValue = c4.ConvertFahrenheitToCelsius();
                        Console.WriteLine(convertedValue + " Celcius");
                        break;

                    case 5:
                        Console.WriteLine("Enter Kelvin Value to convert into Fahrenheit");
                        input = double.Parse(Console.ReadLine());
                        Conversion c5 = new Conversion(input);
                        convertedValue = c5.ConvertKelvinToFahrenheit();
                        Console.WriteLine(convertedValue + " Fahrenheit");
                        break;

                    case 6:
                        Console.WriteLine("Enter Kelvin Value to convert into Celcius");
                        input = double.Parse(Console.ReadLine());
                        Conversion c6 = new Conversion(input);
                        convertedValue = c6.ConvertKelvinToCelsius();
                        Console.WriteLine(convertedValue + " Celsius");
                        break;

                    case 7:
                        Console.WriteLine("\n\n exit.");
                        break;

                    default:

                        Console.WriteLine("Please enter a valid choice.");
                        break;

                }

            } while (x != 7);


            Console.ReadKey();
        }
    }
}
