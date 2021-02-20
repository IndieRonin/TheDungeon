using Godot;
using System;
using EventCallback;

public class Menu : Control
{


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }
    public void OnStartButtonPressed()
    {
        this.Visible = false;

    }
    public void OnOptionsButtonPressed()
    {

    }
    public void OnExitButtonPressed()
    {
        //Exit Game
        GetTree().Quit();
    }
}
