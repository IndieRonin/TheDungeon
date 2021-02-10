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
    //Tge treasure in the room
    int treasure = 0;

    //Override the defualt constructor for the room class
    public Room(int _roomID)
    {
        //Set the rooms id on creation
        roomID = _roomID;
    }
    private void CheckConflicts()
    {
        bool partyKilled = false, mobKilled = false;
        //If the party space is empty we return out of the function
        if (party == null) return;
        //If the mob and the traps are empty but we have a party in the room we give 
        if (mob == null && traps.GetTraps().Count <= 0)
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
            //Set the outcome of the conflict resoltion
            //The mob of monsters where killed
            mobKilled = crei.mobKilled;
            //The party was wiped out
            partyKilled = crei.partyKilled;

            //If the mob was killed the party gets the treasure
            if (mobKilled)
            {
                //Add the treasure to the party
                crei.party.AddTreasure(treasure);
                //Reset the treasure ofr the room
                treasure = 0;
            }
            //If hte party was killed
            if (partyKilled)
            {
                //Add the treasure the party had to the treasure in the room
                treasure += crei.party.GetTreasure();
                //Set the party to empty
                party = null;
            }
        }
    }
}
