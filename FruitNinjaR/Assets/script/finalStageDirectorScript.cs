using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalStageDirectorScript : MonoBehaviour
{
    public GameObject knife1;
    public GameObject knife2;
    public GameObject knife3;
    public Text winText;
    private int winTime;

    // Use this for initialization
    void Start()
    {
        winTime = 200;
    }

    // Update is called once per frame
    void Update()
    {
        if (isClear())
        {
            winTime--;
            //go next level
            if (winTime < 0)
            {
                winText.text = "You Win";
            }
        }
    }

    bool CheckKnife(GameObject knife)
    {
        return knife.GetComponent<knifeScript>().isRusty();
    }

    bool isClear()
    {
        return CheckKnife(knife1) && CheckKnife(knife2) && CheckKnife(knife3);
    }
}