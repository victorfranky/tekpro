using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScriptEN : MonoBehaviour

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
        score.text = "S c o r e : " + scoreValue;
        PlayerPrefs.SetFloat("Player Score", scoreValue);
        PlayerPrefs.Save();

    }
    void Awake()
    {
        
        
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 1)
        {
            scoreValue = 0;
        }
        else;
    }
 
}
