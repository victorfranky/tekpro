using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CobaLagi : MonoBehaviour
{

    public void pindahkemaintambah()
    {
        SceneManager.LoadScene("GameMatematika");
        Time.timeScale = 1f;
    }
}
