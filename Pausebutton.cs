using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausebutton : MonoBehaviour
{
    public GameObject PauseMenumuncul;
    bool isPaused = false;
    public GameObject Buttonnyapause;

    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1f;
            isPaused = false;
            PauseMenumuncul.SetActive(false);
            Buttonnyapause.SetActive(true);

        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            PauseMenumuncul.SetActive(true);
            Buttonnyapause.SetActive(false);
        }
        
    }
}
