using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class highscoreEN : MonoBehaviour
{
    Text score;
    private int hscore;

    void Awake()
    {
        hscore = (ScoreScriptEN.scoreValue);
    }

    void Start()
    {
        score = GetComponent<Text>();       
        
        score.text = "Skor Tertinggi Kamu Adalah : " + PlayerPrefs.GetInt("HighScoreEN", 0).ToString();
    }

    void Update()
    {
        if (hscore > PlayerPrefs.GetInt("HighScoreEN", 0))
        {
            PlayerPrefs.SetInt("HighScoreEN", hscore);
            score.text = "Skor Tertinggi Kamu Adalah : "+hscore.ToString();
        }

    }


}
