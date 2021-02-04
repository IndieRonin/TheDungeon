using Godot;
using System;

public class Actor
{
    /*
    Strength
    Dexterity
    Wisdom
    Intelegence

    Weapon
    Armour
    */
    //The level of the actor
    int level;
    //The health of hte actor
    Health health;

    private void Init()
    {
        //Create the new helth for the ctor and fill the constructor
        health = new Health(10);
    }
}
