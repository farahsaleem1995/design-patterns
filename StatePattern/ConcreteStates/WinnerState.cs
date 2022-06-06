using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Contexts;
using StatePattern.States;

namespace StatePattern.ConcreteStates;

public class WinnerState : IState
{
    private readonly GumballMachine _machine;

    public WinnerState(GumballMachine machine)
    {
        _machine = machine;
    }

    public void Dispense()
    {
        if (_machine.Count > 0)
        {
            _machine.ReleaseBall();
        }

        if (_machine.Count == 0)
        {
            _machine.CurrentState = _machine.SoldOutState;
            return;
        }
        _machine.ReleaseBall();
        Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
        if (_machine.Count > 0)
        {
            _machine.CurrentState = _machine.NoQuarterState;
        }
        else
        {
            Console.WriteLine("Oops, out of gumballs!");
            _machine.CurrentState = _machine.SoldOutState;
        }
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a Gumball");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a Gumball");
    }

    public void Refill()
    {
    }

    public bool TurnCrank()
    {
        Console.WriteLine("Turning again doesn't get you another gumball!");
        return false;
    }
}