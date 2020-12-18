using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainGame : MonoBehaviour
{

    public void tryagain()
    {
        SceneManager.LoadScene("BAHASA INGGRIS");
        Time.timeScale = 1f;
    }
}
