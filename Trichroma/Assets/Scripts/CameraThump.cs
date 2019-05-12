using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraThump : MonoBehaviour
{
    Scene myScene;
    static bool zoom = true;
    public float thumpScale;
    float alpha;
    float camHighVal;
    float camLowVal;
    public float camHVal;
    public float camLVal;
    Camera cam;
    // Use this for initialization
    void Start()
    {
        myScene = SceneManager.GetActiveScene();
        cam = Camera.main;
        alpha = 0;
    }
    public void Thump(float amt, float length)
    {
        float thumpAmt = amt;
  
       // InvokeRepeating("StopThump", 0.1f, 1f);
    }
    void DoThump()
    {
        alpha += Time.deltaTime * thumpScale;
        //Debug.Log(alpha + " Alpha");
        if (myScene.name == "Main Menu")
        {
             camHighVal = (camHVal / 2);
             camLowVal = (camLVal / 2);
        }
        else
        {
             camHighVal = camHVal;
             camLowVal = camLVal;
        }


        float destination = zoom ? camHighVal : camLowVal;
        float destinationTwo = zoom ? camLowVal : camHighVal;
        cam.orthographicSize = Mathf.SmoothStep(cam.orthographicSize, destination, alpha);
        cam.orthographicSize = Mathf.SmoothStep(cam.orthographicSize, destinationTwo, alpha);



        if (alpha >= 1)
        {
            zoom = !zoom;
            alpha = 0;
        }
    }



    void StopThump()
    {
        CancelInvoke("DoThump");
        cam.orthographicSize = Mathf.SmoothStep(cam.orthographicSize, 12, Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.T))
        //{
       // if ((Time.time * 1000) % 2.33 == 0)
            DoThump();
        //else;
        //}
        /*  if (Jump.isCollided == true)
        {
            m_OrthographicCamera.orthographicSize = 10;
        }
        else
        {
            m_OrthographicCamera.orthographicSize = Mathf.Lerp (m_OrthographicCamera.orthographicSize, 10, Time.deltaTime);
        }*/
    }
}
