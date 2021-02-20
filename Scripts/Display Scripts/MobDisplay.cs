using Godot;
using System;
using System.Collections.Generic;
using EventCallback;
public class MobDisplay : Node2D
{
    //The portraits for the monsters
    [Export]
    List<Texture> orcsPortrait = new List<Texture>();
    [Export]
    List<Texture> skeletonPortrait = new List<Texture>();
    [Export]
    List<Texture> cyclopsPortrait = new List<Texture>();
    [Export]
    List<Texture> slimePortrait = new List<Texture>();


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

}
