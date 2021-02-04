using Godot;
using System;
using System.Collections.Generic;
using EventCallback;
public class Mob
{
    //Overiding hte defualt constructor for the class
    public Mob()
    {
        //Run the init the momnet the mob class is creates
        Init();
    }
    //The list of monsters in this mob
    List<Monster> monsters = new List<Monster>();

    // Called when the node enters the scene tree for the first time.
    private void Init()
    {
        AddMonsterEvent.RegisterListener(OnAddMonsterEvent);
    }
    //Add a monster to the mob when the add monster event is called
    private void OnAddMonsterEvent(AddMonsterEvent amei)
    {

    }
}
