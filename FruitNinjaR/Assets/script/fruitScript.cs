using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitScript : MonoBehaviour {

    public Vector2 dir;

	// Use this for initialization
	void Start () {
        //if (dir != null)
        //{
        //    GetComponent<Rigidbody2D>().velocity = dir * 3;
        //}
        //else
        //{
            GetComponent<Rigidbody2D>().velocity = new Vector2(3, 3);
           //Debug.Log("I am in fruit, dir: " + dir);
        //}
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
