using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Contexts;
using StatePattern.States;

namespace StatePattern.ConcreteStates;

public class SoldState : IState
{
    private readonly GumballMachine _machine;

    public SoldState(GumballMachine machine)
    {
        _machine = machine;
    }

    public void Dispense()
    {
        _machine.ReleaseBall(); ;
        if (_machine.Count > 0)
        {
            _machine.CurrentState = _machine.HasQuarterState;
        }
        else
        {
            _machine.CurrentState = _machine.SoldOutState;
        }
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void Refill()
    {
    }

    public bool TurnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball!");
        return false;
    }

    public override string ToString()
    {
        return "dispensing a gumball";
    }
}