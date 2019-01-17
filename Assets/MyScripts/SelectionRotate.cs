using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionRotate : MonoBehaviour
{
    public Vector3 Rotation = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Rotation * Time.deltaTime);
    }
}
