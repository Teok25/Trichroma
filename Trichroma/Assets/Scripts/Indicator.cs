using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour {
    [HideInInspector] public int color;
    public GameObject redChild;
    public GameObject blueChild;
    public GameObject greenChild;
    // Use this for initialization
    void Start () {
        color = ColorChanger.colorChangeOld;
        //redChild.
        //redChild.Find("Indicator Red");
        //.Find("Indicator Blue");
        //.Find("Indicator Green");
        //GetComponentInChildren<SpriteRenderer>().CompareTag("Red");
    }
	
	// Update is called once per frame
	void Update () {
        color = ColorChanger.colorChangeOld;
        if (redChild.tag == "Red")
        {
            if (color == 0)//red
            {
                redChild.SetActive(true);
            }
            if (color == 1)//blue
            {
                redChild.SetActive(false);
            }
            if (color == 2)//green
            {
                redChild.SetActive(false);
            }
        }
        if (blueChild.tag == "Blue")
        {
            if (color == 0)//red
            {
                blueChild.SetActive(false);
            }
            if (color == 1)//blue
            {
                blueChild.SetActive(true);
            }
            if (color == 2)//green
            {
                blueChild.SetActive(false);
            }
        }
        if (greenChild.tag == "Green")
        {
            if (color == 0)//red
            {
                greenChild.SetActive(false);
            }
            if (color == 1)//blue
            {
                greenChild.SetActive(false);
            }
            if (color == 2)//green
            {
                greenChild.SetActive(true);
            }
        }
    }
}
