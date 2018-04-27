using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestruction : MonoBehaviour {

    public float timeToDestruction;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, timeToDestruction);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
