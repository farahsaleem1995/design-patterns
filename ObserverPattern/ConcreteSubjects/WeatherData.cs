using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern.ConcreteSubjects;

public class WeatherData : ISubject
{
    private float _tempreture;
    private float _humidity;
    private float _pressure;
    private readonly IList<IObserver> _observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObserver()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_tempreture, _humidity, _pressure);
        }
    }

    public void SetMeasurements(float temp, float humidity, float pressure)
    {
        _tempreture = temp;
        _humidity = humidity;
        _pressure = pressure;

        NotifyObserver();
    }
}