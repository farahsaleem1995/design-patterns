using ObserverPattern.ConcreteObserver;
using ObserverPattern.ConcreteSubjects;

namespace App.Clients;

public class ObserverClient
{
    public static void Execute()
    {
        var weatherData = new WeatherData();
        _ = new CurrentConditionsDisplay(weatherData);
        _ = new ForcastDisplay(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4f);
        weatherData.SetMeasurements(82, 70, 29.2f);
        weatherData.SetMeasurements(78, 90, 29.2f);
    }
}