using Godot;
using System;
using System.Collections.Generic;
public class TrapsDisplay : Node2D
{
    [Export]
    List<Sprite> TrapSprites = new List<Sprite>();

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
