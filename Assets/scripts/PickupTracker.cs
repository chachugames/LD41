using System;
using UnityEngine;

public class PickupTracker : MonoBehaviour
{
    public int collected, total;

    private void Start()
    {
        collected = 0;
    }
    public void Pickup()
    {
        collected++;
    }
}