using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterScript : MonoBehaviour {

    public GameObject fruit;
    public Sprite fruit1;
    public Sprite fruit2;
    public Sprite fruit3;
    public Sprite fruit4;
    public Sprite fruit5;
    public Sprite fruit6;
    public Sprite fruit7;
    public Sprite emptyFruit;
    private Sprite[] fruitTypes = new Sprite[8];
    public GameObject aimIndicator;
    private bool isAiming;
    private float targetAngle;

	// Use this for initialization
	void Start () 
    {
        Debug.Log("a");
        fruitTypes[0] = fruit1;
        fruitTypes[1] = fruit2;
        fruitTypes[2] = fruit3;
        fruitTypes[3] = fruit4;
        fruitTypes[4] = fruit5;
        fruitTypes[5] = fruit6;
        fruitTypes[6] = fruit7;
        fruitTypes[7] = emptyFruit;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isAiming) {
            Vector3 centerPosition = transform.position;
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float mousex = mousePosition.x;
            float mousey = mousePosition.y;
            float centerx = centerPosition.x;
            float centery = centerPosition.y;
            float diffx = mousex - centerx;
            float diffy = mousey - centery;
            float dist = Mathf.Sqrt(Mathf.Pow(diffx, 2) + Mathf.Pow(diffy, 2));
            float mouseAngle = Mathf.Acos(diffx / dist);
            targetAngle = mouseAngle - (Mathf.PI) / 2;
        }
        if(transform.rotation.eulerAngles.z > 360f) {
            transform.Rotate(0, 0, -(Mathf.PI)*2);
        }
        float targetAngleD = (targetAngle / Mathf.PI) * 180;
        if (transform.rotation.eulerAngles.z - targetAngleD > 1 || transform.rotation.eulerAngles.z - targetAngleD < -1)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, targetAngleD));
        }
        else {
            transform.Rotate(0, 0, 0);
        }
    }

    void OnMouseDown() { 
        isAiming = true;
        aimIndicator.GetComponent<SpriteRenderer>().sprite = fruitTypes[Random.Range(0, 6)];
    }

    private void OnMouseUp()
    {
        if (isAiming) {
            GameObject createdFruit = Instantiate(fruit, transform.position, Quaternion.identity);
            createdFruit.GetComponent<SpriteRenderer>().sprite = aimIndicator.GetComponent<SpriteRenderer>().sprite;
            //Debug.Log(targetAngle * 180 / 3.14);
            float xSpeed = Mathf.Cos(targetAngle + (Mathf.PI) / 2);
            float ySpeed = Mathf.Sin(targetAngle + (Mathf.PI) / 2);
            createdFruit.GetComponent<fruitScript>().dir = new Vector2(xSpeed, ySpeed);
        }
        isAiming = false;
        aimIndicator.GetComponent<SpriteRenderer>().sprite = emptyFruit;
    }
}
