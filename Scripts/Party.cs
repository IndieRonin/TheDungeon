using Godot;
using System;
using System.Collections.Generic;
using EventCallback;

public class Party
{
    //The room the party is in at the moment
    int inRoomID;
    //The treasure the party has with them
    int treasure;
    //The max treasure the party wants before heading out of the dungeon
    int maxTreasure = 500;

    //Overide the defualt constructor for the party class
    public Party(int _roomID)
    {
        //Set the room id for the room the party is in
        inRoomID = _roomID;
        //Run the init method the moment the party class is created
        Init();
    }
    //The list of adeventurers in the party
    List<Adventurer> Adventurers = new List<Adventurer>();

    // Called when the node enters the scene tree for the first time.
    private void Init()
    {
        //Register the listener for the add adventurer event message
        AddAdventurerEvent.RegisterListener(OnAddAdventurerEvent);
        //The listener for the change id event for the party
        SetPartyRoomIDEvent.RegisterListener(OnSetPartyRoomIDEvent);
    }
    //Add an adventurer to the party when the add adventurer event is called
    private void OnAddAdventurerEvent(AddAdventurerEvent aaei)
    {

    }
    public List<Adventurer> GetParty()
    {
        return Adventurers;
    }
    public void AddTreasure(int amount)
    {
        //Add the amount to the treasure
        treasure += amount;
    }
    public int GetTreasure()
    {
        //Get the amount of treasure the party has
        return treasure;
    }
    private void OnSetPartyRoomIDEvent(SetPartyRoomIDEvent spridei)
    {
        //Set the parties room id to the new roomID
        if (spridei.oldID == inRoomID)
        {
            inRoomID = spridei.newID;
        }
    }
}
