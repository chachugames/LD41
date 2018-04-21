using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour {
    public Transform player;
    public float constantSpeed, trackSpeed;
    public float playerOffset;
    private Transform me;
    Vector3 delta, targetPosition;
    public float verticalOffset;
    public Boolean tracking = false;
    public Boolean autoMove;
    // Use this for initialization
    void Start () {
        me = GetComponent<Transform>();
	}
    // Update is called once per frame
    void Update () {

        targetPosition = this.transform.position;
        if(autoMove)targetPosition.x += constantSpeed;
        if (targetPosition.x - player.position.x < playerOffset)
        {
            targetPosition.x += (player.position.x - this.gameObject.transform.position.x)/2;
            tracking = true;
        }
        else
        {
            tracking = false;
        }
        targetPosition.y = player.position.y + verticalOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, trackSpeed * Time.deltaTime);
        this.gameObject.transform.position = smoothedPosition;
    }
}
