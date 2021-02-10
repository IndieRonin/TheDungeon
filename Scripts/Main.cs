using Godot;
using System;
using System.Collections.Generic;
public class Main : Node2D
{
    //The external list of scenes to instantiate when the game runs
    [Export]
    //The list of scenes to be instantiated later
    List<PackedScene> scenes = new List<PackedScene>();
    //The list of nodes that will hold the pre loaded scenes
    List<Node> nodes = new List<Node>();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        //Loop through all the scenes in the list
        foreach (PackedScene scene in scenes)
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
