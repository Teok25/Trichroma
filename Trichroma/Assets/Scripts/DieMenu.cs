using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieMenu : MonoBehaviour {
    int playerDeath = ColorChanger.hp;
    public GameObject canvas;
	// Update is called once per frame
	void Update () {
        playerDeath = ColorChanger.hp;
        if (playerDeath >= 4)
        {
            canvas.SetActive(true);
        }
    }
}
