using Godot;
using System;
using System.Collections.Generic;

public class Room : Node2D
{
    //The mob inside the room
    Node mob = null;
    //The party of adventurers in the room
    Node party = null;
        //The traps indise the room
        Node[] traps = new Node[3];

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    private void CheckRoom()
    {
        //If the party space is empty we return out of the function
        if (party == null) return;
        //If the mob and the traps are empty but we have a party in the room we give 
        if (mob == null && traps.Length <= 0)
        {
                //The party just gets the treasure and gets out of the dungeon
        }
        else
        {
            //We go to the conflict resolution 
        }

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
        //  public override void _Process(float delta)
        //  {
        //      
        //  }
}
