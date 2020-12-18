using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class highscoremtkplus : MonoBehaviour
{
    Text score;
    private int hscore;

    void Awake()
    {
        hscore = (ScoreScriptPlus.scoreValue);
    }

    void Start()
    {
        score = GetComponent<Text>();       
        
        score.text = "Skor Tertinggi Kamu Adalah : "+PlayerPrefs.GetInt("HighScorePlus", 0).ToString();
    }

    void Update()
    {
        if (hscore > PlayerPrefs.GetInt("HighScorePlus", 0))
        {
            PlayerPrefs.SetInt("HighScorePlus", hscore);
            score.text = "Skor Tertinggi Kamu Adalah : " + hscore.ToString();

        }

    }
    
}
