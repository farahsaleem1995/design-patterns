using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Contexts;
using StatePattern.States;

namespace StatePattern.ConcreteStates;

public class HasQuarterState : IState
{
    private readonly GumballMachine _machine;

    public HasQuarterState(GumballMachine machine)
    {
        _machine = machine;
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Quarter returned");
        _machine.CurrentState = _machine.NoQuarterState;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert another quarter");
    }

    public void Refill()
    {
    }

    public bool TurnCrank()
    {
        Console.WriteLine("You turned...");
        var randomWinner = new Random();

        if (randomWinner.Next(9) == 0)
        {
            _machine.CurrentState = _machine.WinnerState;
        }
        else
        {
            _machine.CurrentState = _machine.SoldState;
        }
        return true;
    }

    public override string ToString()
    {
        return "waiting for quarter";
    }
}