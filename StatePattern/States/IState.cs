namespace StatePattern.States;

public interface IState
{
    void Dispense();

    void EjectQuarter();

    void InsertQuarter();

    void Refill();

    bool TurnCrank();
}