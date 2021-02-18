using Godot;
using System;
using System.Collections.Generic;
public class Main : Node2D
{
    //The external list of scenes to instantiate when the game initiates for the first time
    [Export]
    List<PackedScene> mainScenes = new List<PackedScene>();
    //The external list of scenes to instantiate when the game is started from the main menu
    [Export]
    List<PackedScene> gameScenes = new List<PackedScene>();
    //The external list of scenes to instantiate when the game menu is opened
    [Export]
    List<PackedScene> menuScenes = new List<PackedScene>();
    //The list of nodes that will hold the pre loaded scenes
    List<Node> nodes = new List<Node>();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        //Loop through all the scenes in the list
        foreach (PackedScene scene in mainScenes)
        {
            //Add the node of the scenes
            nodes.Add(scene.Instance());
        }
        //Loop through the list of scene nodes and add them to the current scene as children
        foreach (Node node in nodes)
        {
            AddChild(node);
        }
    }
}
