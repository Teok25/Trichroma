using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
    public Transform Particles;
    int score;
    public GameObject textBoxGO;
    int randomNum;
    int oldRand;
    public static int hp;
    public static int colorChangeOld;
    public static bool doPlusOne;
    Text textBox;
    // Use this for initialization
    void Start () {
        randomNum = 1;
        doPlusOne = false;
        textBox = textBoxGO.GetComponent<Text>();
        textBox.text = ("" + score);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (PlayerRotate.angle == 120 && gameObject.tag != "Red")
            {
                //   getBoxTransform = gameObject.transform;
                hp++;
                doPlusOne = false;
                if (hp >= 4)
                {
                    gameObject.SetActive(false);
                    Instantiate(Particles, transform.position, transform.rotation);
                    
                }
            }

            else if (PlayerRotate.angle == 0 && gameObject.tag != "Blue")
            {
                //  getBoxTransform = transform.position, transform.rotation;
                hp++;
                if (hp >= 4)
                {
                    gameObject.SetActive(false);
                    Instantiate(Particles, transform.position, transform.rotation);
                   
                }
            }
            else if (PlayerRotate.angle == -120 && gameObject.tag != "Green")
            {
                // getBoxTransform = transform.position, transform.rotation;
                hp++;
                if (hp >= 4)
                {
                    gameObject.SetActive(false);
                    Instantiate(Particles, transform.position, transform.rotation);
                    
                }
            }
            else
            {
                doPlusOne = true;
                score++;
                textBox.text = ("" + (score));
            }
        }
        oldRand = randomNum;
        randomNum = Random.Range(0, 3);
        colorChangeOld = randomNum;
        Debug.Log("Previous Random: " + oldRand);
        Debug.Log("Current Random: " + randomNum);
        if (col.gameObject.tag == "Player")
        {            
            if (randomNum == 0)//red
            {
                GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f);
                gameObject.tag = "Red";
               
            }
            if (randomNum == 1)//blue
            {
                GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);
                gameObject.tag = "Blue";
                
            }
            if (randomNum == 2)//green
            {
                GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);
                gameObject.tag = "Green";
                
            }
        }
        
        
    }
    // Update is called once per frame
	void Update () {

    }
}
