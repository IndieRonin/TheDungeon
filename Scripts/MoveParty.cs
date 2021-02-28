using Godot;
using System;
using EventCallback;
public class MoveParty : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        PartyMoveEvent.RegisterListener(OnPartyMoveEvent);
    }

    private void OnPartyMoveEvent(PartyMoveEvent pme)
    {

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
