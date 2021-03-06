﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerOffOrOn : MonoBehaviour
{
    public Material powerOffMaterial;
    public Material powerOnMaterial;
    public Renderer Object;
   

    public void PowerOff()
    {
        Object.GetComponent<ConnectingVisualise>().connected = false;
        Object.GetComponent<ConnectingVisualise>().isRunning = false;
        Object.GetComponent<ConnectingVisualise>().power = false;
        Object.material = powerOffMaterial;
    }

    public void PowerOn()
    {
        Object.GetComponent<ConnectingVisualise>().connected = false;
        Object.GetComponent<ConnectingVisualise>().isRunning = false;
        Object.GetComponent<ConnectingVisualise>().power = true;
        Object.material = powerOnMaterial;
    }
}
