using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Contexts;
using StatePattern.States;

namespace StatePattern.ConcreteStates;

public class SoldOutState : IState
{
    private readonly GumballMachine _machine;

    public SoldOutState(GumballMachine machine)
    {
        _machine = machine;
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert a quarter, the machine is sold out");
    }

    public void Refill()
    {
        _machine.CurrentState = _machine.NoQuarterState;
    }

    public bool TurnCrank()
    {
        Console.WriteLine("You turned, but there are no gumballs");
        return false;
    }

    public override string ToString()
    {
        return "sold out";
    }
}