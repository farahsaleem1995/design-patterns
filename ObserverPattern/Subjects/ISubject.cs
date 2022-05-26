using ObserverPattern.Observers;

namespace ObserverPattern.Subjects;

public interface ISubject
{
    void AddObserver(IObserver observer);

    void RemoveObserver(IObserver observer);

    void NotifyObserver();
}