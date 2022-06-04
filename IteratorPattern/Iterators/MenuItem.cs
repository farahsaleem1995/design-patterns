﻿namespace IteratorPattern.Iterators;

public class MenuItem
{
    public MenuItem(string name, string description, bool vegetarian, double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegetarian;
        Price = price;
    }

    public string Name { get; }
    public string Description { get; }
    public bool Vegetarian { get; }
    public double Price { get; }

    public override string ToString()
    {
        return $"{Name}, {Price} -- {Description}";
    }
}