using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    private Rigidbody2D rb2D;
    public float force;
    public static bool isCollided;
        void Awake()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }
	// Use this for initialization
	void Start () {

}

    // Update is called once per frame
    void Update () {
        isCollided = false;
        rb2D.AddForce((transform.up * -1) * (force * 10f));
        rb2D.AddForce((transform.right) * (force * 10f));
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Blue" || col.gameObject.tag == "Green" || col.gameObject.tag == "Red")
        {
            rb2D.AddForce(transform.up * (force * 200f));
            isCollided = true;

        }
    }
}
