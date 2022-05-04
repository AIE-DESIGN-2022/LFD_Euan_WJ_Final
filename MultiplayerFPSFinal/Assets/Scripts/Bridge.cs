using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    MeshRenderer mr;
    MeshCollider col;
    bool isActivated = true;

    public bool startActivated = false;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
        col = GetComponent<MeshCollider>();
    }

    private void Start()
    { 
        if (startActivated) TurnOn();
        else TurnOff();

        if (mr == null || col == null) print("Error in bridge initilization");
    }

    public void ToggleBridge()
    {
        if (isActivated)
        {
            isActivated = false;
            mr.enabled = false;
            col.enabled = false;
        }
        else
        {
            isActivated = true;
            mr.enabled = true;
            col.enabled = true;
        }
    }

    public void TurnOn()
    {
        if (isActivated) return;
        ToggleBridge();
    }

    public void TurnOff()
    {
        if (!isActivated) return;
        ToggleBridge();
    }
}
