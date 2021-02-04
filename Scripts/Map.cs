using Godot;
using System;
using System.Collections.Generic;
public class Map : Node2D
{
    
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
