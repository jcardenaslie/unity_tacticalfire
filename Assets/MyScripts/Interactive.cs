using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    private bool _Selected = false;
    public bool Selected { get { return _Selected; } }
    public bool Swap = false;

    public void Select()
    {
        _Selected = true;
        foreach (var selection in GetComponents<Interaction>())
        {
            selection.Select();
        }
    }

    public void Deselect()
    {
        _Selected = false;
        foreach (var selection in GetComponents<Interaction>())
        {
            selection.Deselect();
        }
    }

    void Start()
    {

    }

    void Update()
    {
        if (Swap)
        {
            Swap = false;
            if (_Selected) Deselect();
            else Select();
        }
    }
}
