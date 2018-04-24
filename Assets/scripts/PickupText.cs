using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupText : MonoBehaviour {
    public PickupTracker pickups;
    public Text text;

    public bool type1;
    private void Update()
    {
        string report = type1 ? pickups.collected + " / " + pickups.total + " Stars" : "You have " + pickups.collected + " out of " + pickups.total + " Stars!";
        text.text = report;
    }
}
