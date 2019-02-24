using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(3, 3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
