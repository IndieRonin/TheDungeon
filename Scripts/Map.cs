using Godot;
using System;
using System.Collections.Generic;
using EventCallback;
public class Map : Node2D
{
    //The positions of the tiles in the map
    Vector2[,] tilePos = new Vector2[30, 30];
    //A list of the rooms id when they are created to use as a reference when getting the room content info
    List<int> roomIDs = new List<int>();
    //The map dictionary, connects the prites with the room scripts
    Dictionary<Room, Node2D> map = new Dictionary<Room, Node2D>();
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    public void RenderRoom()
    {
        

    }
}
