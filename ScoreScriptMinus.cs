using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScriptMinus : MonoBehaviour

{

    public static int scoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {

        score = GetComponent<Text>(); ;


    }

    // Update is called once per frame
    void Update()
    {
        score.text = "S k o r  : " + scoreValue;
        PlayerPrefs.SetFloat("Player Score", scoreValue);
        PlayerPrefs.Save();

    }
    void Awake()
    {


        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 3)
        {
            scoreValue = 0;
        }
        else;
    }

}
