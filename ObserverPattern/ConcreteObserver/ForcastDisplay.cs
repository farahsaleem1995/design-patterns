using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern.ConcreteObserver;

public class ForcastDisplay : IObserver, IDisplayElement
{
    private float _currentPressure;
    private float _lastPressure;
    private readonly ISubject _subject;

    public ForcastDisplay(ISubject subject)
    {
        _subject = subject;
    }

    public void Update(float temp, float humidity, float pressure)
    {
        _lastPressure = _currentPressure;
        _currentPressure = pressure;
        Display();
    }

    public void Display()
    {
        Console.Write("Forecast: ");
        if (_currentPressure > _lastPressure)
        {
            Console.WriteLine("Improving weather on the way!");
        }
        else if (_currentPressure == _lastPressure)
        {
            Console.WriteLine("More of the same");
        }
        else if (_currentPressure < _lastPressure)
        {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}