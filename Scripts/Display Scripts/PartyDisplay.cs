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


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
