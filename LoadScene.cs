using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
    
{

    public void pindahkemainmenu()
    {
        SceneManager.LoadScene("sisa game aja");
        Time.timeScale = 1f;

    }
}
