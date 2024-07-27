using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene("Level1");
    }
    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}
