using System;
using UnityEngine;

public class PickupTracker : MonoBehaviour
{
    public int collected, total;
    public AudioSource pickup;
    private void Start()
    {
        collected = 0;
    }
    public void Pickup()
    {
        pickup.Play();
        collected++;
    }
}