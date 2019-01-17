using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    public float maxZoom = 80;
    public float minZoom = 20;
    public float scrollSpeed = 2f;
    void Update()
    {
        Vector3 pos = transform.position;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * Time.deltaTime * 100;

        pos.y = Mathf.Clamp(pos.y, minZoom, maxZoom);
        transform.position = pos;
    }
}
