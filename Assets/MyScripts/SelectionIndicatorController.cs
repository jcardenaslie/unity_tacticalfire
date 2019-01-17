using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionIndicatorController : MonoBehaviour
{

    MouseManager mm;
    // Start is called before the first frame update
    void Start()
    {
        mm = GameObject.FindObjectOfType<MouseManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(mm.selectedObject != null){

        //     Bounds bigBounds = mm.selectedObject.GetComponentInChildren<Renderer>().bounds;

        //     float diameter = bigBounds.size.x;
        //     diameter *= 1.25f;
        //     this.transform.position =   mm.selectedObject.transform.position;
        //     this.transform.localScale =  new Vector3(diameter, 1, diameter);
        // }
    }
}
