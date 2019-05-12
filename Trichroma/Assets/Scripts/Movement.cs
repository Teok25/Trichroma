using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float magnitude;
    float move;
    // Use this for initialization
    void Start () {
        move = gameObject.transform.position.x;
        magnitude = 5;
    }
	
	// Update is called once per frame
	void Update () {
        move += (magnitude*Time.deltaTime);
	}
}
