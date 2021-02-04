using Godot;
using System;
using System.Collections.Generic;

public class Room
{
    //The mob inside the room
    Mob mob = null;
    //The party of adventurers in the room
    Party party = null;
    //The traps indise the room
    Trap[] traps = new Trap[3];

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
            //We go to the conflict resolution 

            /*
If the conflict is wn by the party they get the treasure, if they lost the treasure keeps growing
            */
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
