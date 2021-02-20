using Godot;
using System;
using System.Collections.Generic;
using EventCallback;
public class RoomDisplay : Node2D
{
    [Export]
    //The list of the rooms posible blueprints for the directions
    List<Texture> roomBlueprints = new List<Texture>();
    [Export]
    List<Texture> roomBuilt = new List<Texture>();

    //The rooms sprite
    Sprite roomSprite;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        //Set the rooms sprite variable to the sprite node in the scene
        roomSprite = GetNode<Sprite>("RoomSprite");
        //Register the get room display info event listener
        SetRoomDisplayEvent.RegisterListener(OnSetRoomDisplayEvent);
    }
    private void OnSetRoomDisplayEvent(SetRoomDisplayEvent srde)
    {
        switch (srde.newType)
        {
            case RoomType.CORE:
                break;
            case RoomType.ENTRANCE:
                break;
            case RoomType.BLUEPRINT:
                roomSprite.Texture = roomBlueprints[0];
                break;
            case RoomType.ROOM:
                break;
        }
    }


}
