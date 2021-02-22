using Godot;
using System;
using System.Collections.Generic;
using EventCallback;
public class SetPartyDisplayEvent : Event<SetPartyDisplayEvent>
{
    //The party in the room that needs to be displayed
    public Party party;
}
