﻿using StrategyPattern.Strategies;

namespace StrategyPattern.ConcreteStaregies;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}