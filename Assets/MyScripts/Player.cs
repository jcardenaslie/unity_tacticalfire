using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSetupDefinition Info;
    public static PlayerSetupDefinition Default;

    void Start()
    {
        Info.ActiveUnits.Add(this.gameObject);
    }

    void OnDestroy()
    {
        Info.ActiveUnits.Remove(this.gameObject);
    }
}
