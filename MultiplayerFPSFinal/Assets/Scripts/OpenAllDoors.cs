using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAllDoors : MonoBehaviour
{
    public void PowerAllDoors()
    {
        DoorMove[] doors = GameObject.FindObjectsOfType<DoorMove>();
        foreach (DoorMove door in doors)
        {
           if (door.poweredDoor)
            {             
            door.GetComponent<BoxCollider>().enabled = true;
            }
        }
    }
}
