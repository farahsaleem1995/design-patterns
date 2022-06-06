using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.Contexts;
using StatePattern.States;

namespace StatePattern.ConcreteStates;

public class NoQuarterState : IState
{
    private readonly GumballMachine _machine;

    public NoQuarterState(GumballMachine machine)
    {
        _machine = machine;
    }

    public void Dispense()
    {
        Console.WriteLine("You need to pay first");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't inserted a quarter");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        _machine.CurrentState = _machine.HasQuarterState;
    }

    public void Refill()
    {
    }

    public bool TurnCrank()
    {
        Console.WriteLine("You turned but there is no quarter");
        return false;
    }

    public override string ToString()
    {
        return "waiting for turn of crank";
    }
}