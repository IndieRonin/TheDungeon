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
        //= TRAP SECTION ==========================================================================
        //If we have traps in the room we deal with them first
        if (crei.traps.GetTraps().Count > 0)
        {
            for (int i = 0; i < crei.traps.GetTraps().Count; i++)
            {
                //If the party list still has an entry in it
                if (crei.party.GetParty().Count > 0)
                {
                    //Remove the first entry in the party list
                    crei.party.GetParty().RemoveAt(0);
                }
                else
                {
                    //If the party was killed we return true
                    crei.partyKilled = true;
                }
            }
        }
        //=========================================================================================

        //= MOB SECTION ===========================================================================
        //Iterate through the mob
        for (int j = 0; j < crei.mob.GetMob().Count; j++)
        {
            //If there are no more monsters left in the mob
            if (crei.mob.GetMob().Count == 0)
            {
                //We set the crei mob killed to true
                crei.mobKilled = true;
                //Break out of the loop as no monsters are left
                break;
            }
            //If there are no more adventurers left in the party
            if (crei.party.GetParty().Count == 0)
            {
                //We set the crei party killed to true
                crei.partyKilled = true;
                //Break out of the loop as no monsters are left
                break;
            }

            //If the mobs monster has a higher level
            if (crei.party.GetParty()[0].GetLevel() < crei.mob.GetMob()[j].GetLevel())
            {
                //Remove the first entry in the party list
                crei.party.GetParty().RemoveAt(0);
            }
            //If the parties adventurer has a higher level
            if (crei.party.GetParty()[0].GetLevel() > crei.mob.GetMob()[j].GetLevel())
            {
                //Remove the first entry in the party list
                crei.mob.GetMob().RemoveAt(j);
            }
            //If the monster and the adventurer are on the same level
            if (crei.party.GetParty()[0].GetLevel() == crei.mob.GetMob()[j].GetLevel())
            {
                //Create a new random nuber generator
                RandomNumberGenerator rng = new RandomNumberGenerator();
                //Randomize the random number generators output
                rng.Randomize();
                //Let the random number generator select between 0 and 1 
                int deathTo = rng.RandiRange(0, 1);
                //If 0 was selected the adventurer dies
                if (deathTo == 0)
                {
                    //Remove the first entry in the party list
                    crei.party.GetParty().RemoveAt(0);
                }
                //if 1 was selected the monster dies
                else
                {
                    //Remove the first entry in the party list
                    crei.mob.GetMob().RemoveAt(0);
                }
            }
        }
    }
    //=========================================================================================
}

