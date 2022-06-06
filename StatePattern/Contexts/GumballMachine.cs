using System.Text;
using StatePattern.ConcreteStates;
using StatePattern.States;

namespace StatePattern.Contexts
{
    public class GumballMachine
    {
        public GumballMachine(int count)
        {
            CurrentState = new NoQuarterState(this);
            Count = count;
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldOutState = new SoldOutState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
        }

        public IState CurrentState { get; set; }
        public int Count { get; private set; }
        public IState NoQuarterState { get; }
        public IState HasQuarterState { get; }
        public IState SoldState { get; }
        public IState SoldOutState { get; }
        public IState WinnerState { get; }

        public void EjectQuarter()
        {
            CurrentState.EjectQuarter();
        }

        public void InsertQuarter()
        {
            CurrentState.InsertQuarter();
        }

        public void TurnCrank()
        {
            var result = CurrentState.TurnCrank();
            if (result)
            {
                CurrentState.Dispense();
            }
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count > 0)
            {
                Count--;
            }
        }

        public void Refill(int count)
        {
            Count += count;
            Console.WriteLine("The gumball machine was just refilled; its new count is: " + Count);
            CurrentState.Refill();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nC#-enabled Standing Gumball Model #2022");
            result.Append("\nInventory: " + Count + " gumball");
            if (Count != 1)
            {
                result.Append('s');
            }
            result.Append('\n');
            result.Append("Machine is " + CurrentState + "\n");
            return result.ToString();
        }
    }
}