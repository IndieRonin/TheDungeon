using Godot;
using System;
using System.Collections.Generic;
using EventCallback;

public class Party
{
    //Overide the defualt constructor for the party class
    public Party()
    {
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
    }
    //Add an adventurer to the party when the add adventurer event is called
    private void OnAddAdventurerEvent(AddAdventurerEvent aaei)
    {

    }
}
