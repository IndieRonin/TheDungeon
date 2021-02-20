using Godot;
using System;

namespace EventCallback
{
    public class SetRoomDisplayEvent : Event<SetRoomDisplayEvent>
    {
        //The new type of the room
        public RoomType newType;
    }
}
