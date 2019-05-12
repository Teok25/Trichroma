using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReturnToMenu : MonoBehaviour
{
    public void changeMenuScene()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
