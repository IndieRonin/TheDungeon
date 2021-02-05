using Godot;
using System;
namespace EventCallback
{
    public class SetPartyRoomIDEvent : Event<SetPartyRoomIDEvent>
    {
        //The new aand old ID for the room
        public int oldID, newID;
    }
}

