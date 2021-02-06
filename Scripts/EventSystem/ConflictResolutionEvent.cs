using Godot;
using System;
namespace EventCallback
{
    public class ConflictResolutionEvent : Event<ConflictResolutionEvent>
    {
        //The mob inside the room
        public Mob mob;
        //The party of adventurers in the room
        public Party party;
        //The traps indise the room
        public Traps traps;
        //The return bool if the party has been whiped out
        public bool partyKilled = false;
        //The return bool if the mob has been whiped out
        public bool mobKilled = false;
    }
}
