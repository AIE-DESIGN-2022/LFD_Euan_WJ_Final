using System.Collections;
using System.Collections.Generic;
using Unity.FPS.AI;
using UnityEngine;

public class Powerscript : MonoBehaviour
{
    public void TurnOnAllLights()
    {
        Powerscript[] powererdLights = GameObject.FindObjectsOfType<Powerscript>();
        foreach(Powerscript powererdLight in powererdLights)
        {
            if (powererdLight.GetComponentInChildren<Light>() != null)
            {
                powererdLight.GetComponentInChildren<Light>().enabled = true;
            }
        }
    }

    private void TurnOnWire(Wire.WireType wireTypeToTurnOn)
    {
        Wire[] allWires = GameObject.FindObjectsOfType<Wire>();
        foreach(Wire wire in allWires)
        {
            if (wire.wireType == wireTypeToTurnOn)
            {
                wire.WireTurnOn();
            }
        }
    }

    public void TurnonRedWires()
    {
        TurnOnWire(Wire.WireType.Red);
    }
    public void TurnonBlueWires()
    {
        TurnOnWire(Wire.WireType.Blue);
    }
    public void TurnonGreenWires()
    {
        TurnOnWire(Wire.WireType.Green);
    }
    public void TurnonYellowWires()
    {
        TurnOnWire(Wire.WireType.Yellow);
    }

    public void ActivateAllTurrets()
    {
        EnemyController[] turrets = GameObject.FindObjectsOfType<EnemyController>();
        foreach (EnemyController turret in turrets)
        {
            if (turret.GetComponent<EnemyTurret>() != null)
            {
                turret.ActivateTurret();
            }
        }    
    }
}
