using Godot;
using System;
using System.Collections.Generic;
using EventCallback;
public class Map : Node2D
{
    List<int> roomIDs = new List<int>();
    //The map dictionary, connects the prites with the room scripts
    Dictionary<Room, Node2D> map = new Dictionary<Room, Node2D>();
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
