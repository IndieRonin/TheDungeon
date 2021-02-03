using Godot;
using System;

public enum DamageType
{
    //Physical
    BLUNT,
    PIERCING,
    SLASHING,
    //Magical
    MAGICAL,
    //Elemental (Sub class of magical)
    FIRE,
    EARTH,
    WATER,
    WIND
};

public class Trap
{
    /*
    Damage Type
    Damage Amount
    Damage Time
    Group Damage
    */

    int damage;

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
