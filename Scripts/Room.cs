using Godot;
using System;
using System.Collections.Generic;
using EventCallback;

public enum RoomType
{
    CORE,
    ENTRANCE,
    BLUEPRINT,
    ROOM
};
public class Room
{
    //The rooms Id
    int roomID;
    //The maximum traps allowed in the room
    int maxTraps = 3;
    //The room type
    RoomType type;
    //The public accesor for hte rooms type
    public RoomType Type
    {
        get { return type; }
        set
        {
            //If the new value is not equal to the old value
            if (type != value)
            {
                //Set the new type of the room
                type = value;
                //Send a message to the room listeners
                SetRoomDisplayEvent srde = new SetRoomDisplayEvent();
                srde.callerClass = "Room - room type setter";
                srde.newType = type;
                srde.FireEvent();
            }
        }
    }

    //The mob inside the room with the methods to call when the mob is changed
    Mob mob
    {
        get { return mob; }
        set
        {
            //If the mob is not the same as the current mob then the setting is done
            if (mob != value)
            {
                //Set the mob to the new incomming mob
                mob = value;
                //Send the message to the mob display event
                SetMobDisplayEvent smde = new SetMobDisplayEvent();
                smde.callerClass = "Room - mob varaible setter";
                smde.mob = mob;
                smde.FireEvent();
            }
        }
    }
    //The party of adventurers in the room with the methods to call when the party is changed
    Party party
    {
        get { return party; }
        set
        {
            //If the party is not the same as the current party then the setting is done
            if (party != value)
            {
                //Set the party to the new incomming value
                party = value;
                //Call the event message to set party display event to update the party display
                SetPartyDisplayEvent spde = new SetPartyDisplayEvent();
                spde.callerClass = "Room - party variable setter";
                spde.party = party;
                spde.FireEvent();
            }
        }
    }

    //The traps in the room
    Traps traps
    {
        get{return traps;}
        set
        {
if(traps)
        }
    }

    //Tge treasure in the room
    int treasure = 0;
    //The entrances to the room: north, west, south, east
    bool n = false, w = false, s = false, e = false;

    //Override the defualt constructor for the room class
    public Room(int _roomID, RoomType newType)
    {
        //Set the rooms id on creation
        roomID = _roomID;
        //Set the rooms type
        Type = newType;
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
