﻿namespace DecoratorPattern.Components;

public abstract class Beverage
{
    protected string Description = "Unknown Beverage";

    public virtual string GetDescription()
    {
        return Description;
    }

    public abstract double Cost();
}