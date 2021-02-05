using Godot;
using System;
using EventCallback;

public class ConflictResolution : Node
{

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        //Event message listener for the conflict resolution event message
        ConflictResolutionEvent.RegisterListener(OnConflictResolutionEvent);
    }

    private void OnConflictResolutionEvent(ConflictResolutionEvent crei)
    {
        //If we have traps in the room we deal with them first
        if (crei.traps.Length > 0)
        {
            for (int i = 0; i < crei.traps.Length; i++)
            {
                if(crei.party.GetParty())
            }
        }
        else
        {
            for
        }
        /*
               1. Take in the rooms part, mob and traps - Done
               2. Handle traps on the part first
               3. Handle conflict in parties
           */

    }
}
