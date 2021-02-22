using Godot;
using System;
using System.Collections.Generic;
public class PartyDisplay : Node2D
{
    [Export]
    //The sprites for the different portraits of the adventurers
    List<Texture> wizardPortrait = new List<Texture>();
    [Export]
    List<Texture> sorcererPortrait = new List<Texture>();
    [Export]
    List<Texture> fighterPortrait = new List<Texture>();
    [Export]
    List<Texture> barbarianPortrait = new List<Texture>();
    [Export]
    List<Texture> clericPortrait = new List<Texture>();
    [Export]
    List<Texture> paladinPortrait = new List<Texture>();
    [Export]
    List<Texture> rangerPortrait = new List<Texture>();

    //Get the party list
    //Iterate through the list 
    //Get the adventurer type from the party list
    //Set the portriat of 
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        SetPartyDisplayEvent.RegisterListener(OnSetPartyDisplayEvent);
    }

//The method to be called if there is a message for the party display
    private void OnSetPartyDisplayEvent(SetPartyDisplayEvent spde)
    {
        
    }
}
