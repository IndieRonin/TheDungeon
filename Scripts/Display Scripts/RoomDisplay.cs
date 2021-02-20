using Godot;
using System;
using System.Collections.Generic;

public class RoomDisplay : Node2D
{
    [Export]
    //The list of the rooms posible blueprints for the directions
    List<Sprite> roomBlueprints = new List<Sprite>();
    [Export]
    List<Sprite> roomBuilt = new List<Sprite>();

    //The rooms sprite
    Sprite roomSprite;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        //Set the rooms sprite variable to the sprite node in the scene
        roomSprite = GetNode<Sprite>("RoomSprite");
    }
}
