using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorPointers : MonoBehaviour
{

    public Texture2D defaultPointer;
    public Texture2D rotatePointer;
    public Texture2D selectPointer;
    public Texture2D panPointer;
    public Texture2D zoomPointer;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    private string mouseState = "default";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1) )
        {
            mouseState = "default";
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
        if (Input.GetMouseButton(0)){
            if  (mouseState != "panning"){
                mouseState = "panning";
                Cursor.SetCursor(panPointer, hotSpot, cursorMode);
            }
        }
        if (Input.GetMouseButton(1))
        {
            if (mouseState != "rotating")
            {
                mouseState = "rotating";
                Cursor.SetCursor(rotatePointer, hotSpot, cursorMode);
            }
        }
    }
}
