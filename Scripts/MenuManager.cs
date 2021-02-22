using Godot;
using System;
using EventCallback;

public class Menu : CanvasLayer
{
    //Menus for the game
    Control main;
    Control options;
    Control action;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        //Assigning the nodes in the menu scene to the nodes in the script
        main.GetNode<Control>("Main");
        options.GetNode<Control>("Options");
        //Set the options menu to not be visible after instantiation
        options.Visible = false;
        action.GetNode<Control>("Action");
        //Set the action menu to not be visible after instantiation
        action.Visible = false;

    }
    public void OnStartButtonPressed()
    {

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
