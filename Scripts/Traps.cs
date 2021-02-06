using Godot;
using System;
using System.Collections.Generic;
using EventCallback;
public class Traps
{
    //The roomID that the traps are in
    int roomID;
    //The traps indise the room
    List<Trap> traps = new List<Trap>();
    public Traps(int _roomID)
    {
        //Set the traps claas to the room that spawned it
        roomID = _roomID;
        //Run the init of the traps class
        Init();
    }

    // Called when the class is constructed
    private void Init()
    {
        //Add the this to the listeners for the add trap event message
        AddTrapEvent.RegisterListener(OnAddTrapEvent);
    }

    private void OnAddTrapEvent(AddTrapEvent atei)
    {
        //If there are three or less trps we can add a new trap
        if(traps.Count < 3)
        {
            //We add a new trap here
        }
    }

    //Return the traps in the room
    public List<Trap> GetTraps()
    {
        //Return the traps in the list
        return traps;
    }
}
