using System;
namespace Assignment1
{
    public class Conversion
    {
        private double conversionValue;
        public double ConversionValue { get => conversionValue; set => conversionValue = value; }
        public Conversion()
        {
            this.ConversionValue = 1;
        }

        public Conversion(double conversionvalue) {
            this.ConversionValue = conversionValue;
        }
        public double ConvertCelciusToFahrenheit() {
            return ((this.conversionValue * 9) / 5) + 5;
        }
        public double ConvertCelciusToKelvin() {
            return this.conversionValue + 273.15;
        }
        public double ConvertKelvinToFahrenheit() {
            return (((this.conversionValue - 273.15) * 9) / 5) + 32;
        }
        public double ConvertKelvinToCelsius() {
            return this.conversionValue - 273.15;
        }
        public double ConvertFahrenheitToKelvin() {
            return (((this.conversionValue - 32) * 5) / 9) + 273.15;
        }
        public double ConvertFahrenheitToCelsius() {
            return (((this.conversionValue - 32) * 5) / 9);
        }
    }
}
