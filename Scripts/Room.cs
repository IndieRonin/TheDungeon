using Godot;
using System;
using System.Collections.Generic;
using EventCallback;
public class Room
{
    //The rooms Id
    int roomID;
    //The mob inside the room
    Mob mob = null;
    //The party of adventurers in the room
    Party party = null;
    //The traps in the room
    Traps traps = null;

//Override the defualt constructor for the room class
    public Room(int _roomID)
    {
        //Set the rooms id on creation
        roomID = _roomID;
    }

    private void CheckConflicts()
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
            //Set up the conflict resolution event message
            ConflictResolutionEvent crei = new ConflictResolutionEvent();
            //Set the party to send in the message
            crei.party = party;
            //Set the mob to send in the message
            crei.mob = mob;
            //Set the traps to send in the message
            crei.traps = traps;
            //Send the event message
            crei.FireEvent();
        }
    }
    //If the party wins they get the treasure
    private void GetTreasure()
    {

    }
    //If the mob wins the treasure grows
    private void GrowTreasure()
    {

    }

    //If the mob wins and there is no treasure it gets added to the room
    private void AddTreasure()
    {

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
