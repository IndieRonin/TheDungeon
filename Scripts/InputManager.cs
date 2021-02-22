using Godot;
using System;
using EventCallback;

public class InputManager : Node
{
    //The ray used to detect collisions with objects
    RayCast2D touchRay;
    //The touch positions
    Vector2 touchStart, touchEnd;
    public override void _Ready()
    {
        //Grab a reference to the ray node in teh scene
        touchRay = GetNode<RayCast2D>("HitRay");
        //Set the ray so it detects collisions with areas
        touchRay.CollideWithAreas = true;
    }
    public override void _UnhandledInput(Godot.InputEvent @event)
    {
        //If there was a touch screen event
        if (@event is InputEventScreenTouch screenTouch)
        {
            //If the screenTouch was pressed
            if (screenTouch.Pressed)
            {
                //Enadble the touchRay
                touchRay.Enabled = true;
                //Set its current position to the taps position
                touchRay.Position = screenTouch.Position;
                //Forces the raycast to update and detect the collision with the building object
                touchRay.ForceRaycastUpdate();
                //Check if there is a collision from the touch array
                if (touchRay.IsColliding())
                {
                    //Get the node that the ray collided with
                    Node2D hitNode = touchRay.GetCollider() as Node2D;
                    //Get the position where the screen was touched
                    touchStart = screenTouch.Position;
                    if (hitNode.IsInGroup("Room"))
                    {

                    }
                }
            }
            else
            {
                //Get the position where the screen touch was released
                touchEnd = screenTouch.Position;
                //Where the touch was released used for dragging or to check if and object with a collider on was clicked on
            }
        }
    }
}
