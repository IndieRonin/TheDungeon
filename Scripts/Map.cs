using Godot;
using System;
using System.Collections.Generic;
using EventCallback;
public class Map : Node2D
{
    //The Size of the map can be set in the inspector
    [Export]
    //The size of the map to be able to adjust it easily 
    int mapSize;
    [Export]
    //This will hold the different types of rooms (The dungeon core, entrance and normal rooms)
    PackedScene roomScene = new PackedScene();

    //A list of the rooms id when they are created to use as a reference when getting the room content info
    List<int> roomIDs = new List<int>();
    //The map dictionary, connects the prites with the room scripts
    Dictionary<Room, Node2D> map = new Dictionary<Room, Node2D>();
    // Called when the node enters the scene tree for the first time.

    public override void _Ready()
    {
        //Set the intitial value of the room ids
        int tempRoomID = 0;
        //The new to be created every iteration
        Room newRoom;
        //Loop through the map size and populate the map
        for (int y = 0; y < mapSize; y++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                //Create a new node for the room node
                Node2D newRoomNode;
                newRoomNode = (Node2D)roomScene.Instance();
                //Iterate the room id every loop
                tempRoomID++;
                //Get the middle of the map to create the dungeon core
                if (x == mapSize / 2 && y == mapSize / 2)
                {
                    //Create the new room script and inject the rooms new id
                    newRoom = new Room(tempRoomID, RoomType.CORE);
                }
                else
                {
                    //Create the new room script and inject the rooms new id
                    newRoom = new Room(tempRoomID, RoomType.BLUEPRINT);
                }
                //Create the new room
                map.Add(newRoom, newRoomNode);
                //Set the rooms position in the game world
                newRoomNode.Position = new Vector2(x * 256, y * 256);
                //Add the room node as a child of the scene
                AddChild(newRoomNode);
                //Add hte room id to the list
                roomIDs.Add(tempRoomID);

            }
        }
    }
    //Draws the room sprite in the correct place
    private void DrawRoom()
    {

    }


}
