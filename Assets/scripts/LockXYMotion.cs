using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockXYMotion : MonoBehaviour {
    public bool X, Y;
    private Vector3 current;
	// Use this for initialization
	void Start () {
        current = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (X)
        {
            this.gameObject.transform.position = new Vector3(current.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
        if (Y)
        {
            this.gameObject.transform.position = new Vector3( this.gameObject.transform.position.x, current.y, this.gameObject.transform.position.z);
        }
    }
}
