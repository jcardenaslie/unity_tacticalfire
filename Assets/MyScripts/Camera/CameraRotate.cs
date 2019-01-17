using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    private MouseManager mm;
    private const float Y_ANGLE_MIN = 10f;
    private const float Y_ANGLE_MAX = 70f;
    public Transform lookAt;
    public Transform camTransform;

    public float distance = 20f;
    private float currentX = 0f;
    private float currentY = 0f;
    public float sensitivityX = 4f;
    public float sensitivityY = 1f;

    public float maxZoom = 80;
    public float minZoom = 20;
    public float scrollSpeed = 2f;

    private void Start(){
        camTransform = transform;
        mm = GameObject.FindObjectOfType<MouseManager>();
    }

    private void Update(){
        if (Input.GetMouseButton(1)){
            currentX += Input.GetAxis("Mouse X") * sensitivityX ;
            currentY -= Input.GetAxis("Mouse Y") * sensitivityY;

            currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        }
    }

    private void LateUpdate(){
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);

        // ZOOM
        Vector3 pos = transform.position;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        distance -= scroll * scrollSpeed * 10;
        distance = Mathf.Clamp(distance, minZoom, maxZoom); 

    }

}
