using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern;

public class TheaterLights
{
    private readonly string _description;

    public TheaterLights(String description)
    {
        _description = description;
    }

    public void On()
    {
        Console.WriteLine($"{_description} on");
    }

    public void Off()
    {
        Console.WriteLine($"{_description} off");
    }

    public void Dim(int level)
    {
        Console.WriteLine($"{_description} dimming to {level}%");
    }

    public override string ToString()
    {
        return _description;
    }
}