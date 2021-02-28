using Godot;
using System;

public class CameraManager : Camera2D
{
    //The minimum zoom level for the camera
    float minZoom = .5f;
    //The maximum zoom level for hte camera
    float maxZoom = 2f;
    //The speed of the zoom
    float zoomSpeed = 0.05f;
    //The sensitivity of the zooming
    float zoomSensitivity = 10;


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
