using FacadePattern;
using FacadePattern.Facades;

namespace App.Clients;

public class FacadeClient
{
    public static void Execute()
    {
        var amp = new Amplifier("Amplifier");
        var tuner = new Tuner("AM/FM Tuner", amp);
        var player = new StreamingPlayer("Streaming Player", amp);
        var cd = new CdPlayer("CD Player", amp);
        var projector = new Projector("Projector", player);
        var lights = new TheaterLights("Theater Ceiling Lights");
        var screen = new Screen("Theater Screen");
        var popper = new PopcornPopper("Popcorn Popper");

        var homeTheater = new HomeTheaterFacade(
            amp,
            tuner,
            player,
            cd,
            projector,
            screen,
            lights,
            popper);

        homeTheater.WatchMovie("The Lord of the Rings: The Two Towers");
        Console.WriteLine();
        homeTheater.EndMovie();
    }
}