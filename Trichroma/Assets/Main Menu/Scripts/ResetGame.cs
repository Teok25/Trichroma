using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public void changeMenuScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ColorChanger.hp = 0;
        PlayerRotate.angle = 0;
    }
}
