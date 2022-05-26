using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern.ConcreteObserver;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _tempreture;
    private float _humidity;
    private readonly ISubject _weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        _weatherData.AddObserver(this);
    }

    public void Update(float temp, float humidity, float pressure)
    {
        _tempreture = temp;
        _humidity = humidity;

        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_tempreture}F degrees and {_humidity}% humidity.");
    }
}