using Google.Protobuf;
using Newtonsoft.Json.Linq;
using System;
using APIsAndJSON;

namespace APIsAndJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1 - Quotes

            //Stylez.Style();

            #endregion

            #region Exercise 2 - Weather


            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();


            Console.Write("Please enter your zipcode: ");
            var zipCode = Console.ReadLine();


            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";


            Console.WriteLine();


            Console.WriteLine($"It is currently {OpenWeatherMapAPI.GetTemp(apiCall)}° Farenheit in your location!");
            #endregion

        }
    }
}