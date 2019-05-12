using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour {

    public float smooth = 1f;
    public static float angle;
    private Quaternion targetRotation;
	void Start () {
        //  anim = GetComponent<Animator>();
        targetRotation = gameObject.transform.rotation;
        
    }

	// Update is called once per frame
	void Update () {
       // 
        if (Input.GetKeyDown("d"))
        {
            targetRotation *= Quaternion.AngleAxis(120, Vector3.back);
            if (angle == -120)
            {
                angle = 120;
            }
            else if (angle == 120)
            {
                angle = 0;
            }
            else if (angle == 0)
            {
                angle = -120;
            }
            Debug.Log("Angle = " + angle);

            //gameObject.transform.Rotate(0, 0, -120);
        }
        if (Input.GetKeyDown("a"))
        {
            //  anim.Play("PlayerRotateAnim");
            targetRotation *= Quaternion.AngleAxis(-120, Vector3.back);
            if (angle == -120)
            {
                angle = 0;
            }
            else if (angle == 120)
            {
                angle = -120;
            }
            else if (angle == 0)
            {
                angle = 120;
            }
        }
        if (Input.mousePosition.x > Screen.width / 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                targetRotation *= Quaternion.AngleAxis(120, Vector3.back);
                if (angle == -120)
                {
                    angle = 120;
                }
                else if (angle == 120)
                {
                    angle = 0;
                }
                else if (angle == 0)
                {
                    angle = -120;
                }
                Debug.Log("Angle = " + angle);
            }

        }
        if (Input.mousePosition.x < Screen.width / 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                targetRotation *= Quaternion.AngleAxis(-120, Vector3.back);
                if (angle == -120)
                {
                    angle = 0;
                }
                else if (angle == 120)
                {
                    angle = -120;
                }
                else if (angle == 0)
                {
                    angle = 120;
                }
            }
            
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 12 * smooth * Time.deltaTime);
    }

}
