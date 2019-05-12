using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuPlayGame : MonoBehaviour
{
    public void changeMenuScene()
    {
        SceneManager.LoadScene("Main Game");
        ColorChanger.hp = 0;
        PlayerRotate.angle = 0;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
