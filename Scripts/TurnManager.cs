using Godot;
using System;

public enum TurnStates
{
    CALCULATE_RESOURCES,
    PARTY_MOVE,
    CONFLICT_RESOLUTION,
    PLAYER_TURN
};
public class TurnManager : Node
{
    //The states for the turn manager to loop through
    TurnStates state;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void OnChangeState(TurnStates newState)
    {
        //Set the new state
        state = newState;
    }
}
