using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitScript : MonoBehaviour {

    public Vector2 dir;
    private bool isVelocityInit;

	// Use this for initialization
	void Start () {
        isVelocityInit = false;
          
	}
	
	// Update is called once per frame
	void Update () {
        if(!isVelocityInit) {
            GetComponent<Rigidbody2D>().velocity = dir * 3;
            isVelocityInit = true;
        }

    }


}
