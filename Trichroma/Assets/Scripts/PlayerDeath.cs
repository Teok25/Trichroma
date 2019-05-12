using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    int playerHp = ColorChanger.hp;
    public Transform DeadPlayer;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        playerHp = ColorChanger.hp;
        if (playerHp >= 4)
        {
            gameObject.SetActive(false);
            Instantiate(DeadPlayer, gameObject.transform.position, gameObject.transform.rotation);
        }
	}
}
