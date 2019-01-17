using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : Interaction
{
    public GameObject DisplayItem;
    public override void Deselect()
    {
        DisplayItem.SetActive(false);
    }
    public override void Select()
    {
        DisplayItem.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        DisplayItem.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
