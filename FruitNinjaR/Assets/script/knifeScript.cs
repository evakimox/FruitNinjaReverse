using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeScript : MonoBehaviour {

    public Sprite rustyKnife;
    bool rusty;

	// Use this for initialization
	void Start () {
        rusty = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "fruit") {
            rusty = true;
            GetComponent<SpriteRenderer>().sprite = rustyKnife;
        }
    }

    private void OnMouseDrag()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = (pos);
    }

    public bool isRusty() {
        return rusty;
    }
}
