using Godot;
using System;
using System.Collections.Generic;
using EventCallback;
public class Mob
{
    //The room the mob is in at the moment
    int inRoomID;
    //Overiding hte defualt constructor for the class
    public Mob(int _roomID)
    {
        //Set the room id for the room the mob is in
        inRoomID = _roomID;
        //Run the init the momnet the mob class is creates
        Init();
    }
    //The list of monsters in this mob
    List<Monster> monsters = new List<Monster>();

    // Called when the node enters the scene tree for the first time.
    private void Init()
    {
        //Adds a monster to the mob
        AddMonsterEvent.RegisterListener(OnAddMonsterEvent);
        //The listener for the change ID event for the mob
        SetMobRoomIDEvent.RegisterListener(OnSetMobRoomIDEvent);
    }
    //Add a monster to the mob when the add monster event is called
    private void OnAddMonsterEvent(AddMonsterEvent amei)
    {

    }
    public List<Monster> GetMob()
    {
        return monsters;
    }
    private void OnSetMobRoomIDEvent(SetMobRoomIDEvent smridei)
    {
        if (smridei.oldID == inRoomID)
        {
            inRoomID = smridei.newID;
        }
    }
}
