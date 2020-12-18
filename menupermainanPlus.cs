using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupermainanPlus : MonoBehaviour
{

    public void pindahmtktambah()
    {
        SceneManager.LoadScene("GameMatematika");
        Time.timeScale = 1f;
    }
}
