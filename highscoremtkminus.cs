using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class highscoremtkminus : MonoBehaviour
{
    Text score;
    private int hscore;

    void Awake()
    {
        hscore = (ScoreScriptMinus.scoreValue);
    }

    void Start()
    {
        score = GetComponent<Text>();

        score.text = "Skor Tertinggi Kamu Adalah : " + PlayerPrefs.GetInt("HighScoreMin", 0).ToString();
    }

    void Update()
    {
        if (hscore > PlayerPrefs.GetInt("HighScoreMin", 0))
        {
            PlayerPrefs.SetInt("HighScoreMin", hscore);
            score.text = "Skor Tertinggi Kamu Adalah : "+hscore.ToString();
        }

    }

}
