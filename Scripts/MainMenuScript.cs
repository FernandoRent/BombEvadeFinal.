using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Menu : MonoBehaviour
{




    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Juego");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
