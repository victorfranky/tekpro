using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupermainanMin : MonoBehaviour
{

    public void pindahmtkkurang()
    {
        SceneManager.LoadScene("GameMateMatikaKurang");
        Time.timeScale = 1f;
    }
}
