using Godot;
using System;
namespace EventCallback
{
    public class SetMobRoomIDEvent : Event<SetMobRoomIDEvent>
    {
        //The new aand old ID for the room
        public int oldID, newID;
    }
}

