using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    [SerializeField] Material offWire;
    [SerializeField] Material onWire;
    public WireType wireType;

    public enum WireType
    {
        Red,
        Blue,
        Green,
        Yellow
    }

    public void WireTurnOn()
    {
        gameObject.GetComponent<Renderer>().material = onWire;
    }

}
