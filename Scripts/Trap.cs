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
}
