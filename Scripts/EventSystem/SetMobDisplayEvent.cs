using Godot;
using System;
using EventCallback;
public class SetMobDisplayEvent : Event<SetMobDisplayEvent>
{
    //The mob that needs to be ppassed to the mob display scene
    public Mob mob;
}
