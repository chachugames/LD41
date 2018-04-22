using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupText : MonoBehaviour {
    public PickupTracker pickups;
    public Text text;
	

    private void OnEnable()
    {
        string report = "You have " + pickups.collected + " out of " + pickups.total + " Stars!";
        text.text = report;
    }
}
