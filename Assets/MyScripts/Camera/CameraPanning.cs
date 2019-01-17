using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPanning : MonoBehaviour
{
    public float mouseSensitivity = 1f;
    private Vector3 lastPosition;
    public Vector2 panLimit;
    public float scrollSpeed = 2f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Debug.Log("LeftButtonDown");
            lastPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            // Debug.Log("LeftButton");
            Vector3 delta = Input.mousePosition - lastPosition;
            transform.Translate(delta.x * mouseSensitivity * Time.deltaTime, 0, delta.y * mouseSensitivity * Time.deltaTime);

            Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(pos.x, -panLimit.x, +panLimit.x);
            pos.z = Mathf.Clamp(pos.z, -panLimit.y, +panLimit.y);

            transform.position = pos;
        }

        


    }
}

