﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KamuHebatKurang : MonoBehaviour
{


    public GameObject duapuluh;
    public GameObject limapuluh;
    public GameObject delapanpuluh;
    public GameObject sembilanpuluh;
    public GameObject seratus;



    // Update is called once per frame
    void Update()
    {
        if (ScoreScriptMinus.scoreValue <= 20)
        {
            duapuluh.SetActive(true);
            limapuluh.SetActive(false);
            delapanpuluh.SetActive(false);
            sembilanpuluh.SetActive(false);
            seratus.SetActive(false);
        }
        else if (ScoreScriptMinus.scoreValue <= 50)
        {
            limapuluh.SetActive(true);
            duapuluh.SetActive(false);
            delapanpuluh.SetActive(false);
            sembilanpuluh.SetActive(false);
            seratus.SetActive(false);
        }
        else if (ScoreScriptMinus.scoreValue <= 80)
        {
            delapanpuluh.SetActive(true);
            duapuluh.SetActive(false);
            limapuluh.SetActive(false);
            sembilanpuluh.SetActive(false);
            seratus.SetActive(false);
        }
        else if (ScoreScriptMinus.scoreValue <= 90)
        {
            delapanpuluh.SetActive(false);
            duapuluh.SetActive(false);
            limapuluh.SetActive(false);
            sembilanpuluh.SetActive(true);
            seratus.SetActive(false);
        }
        else if (ScoreScriptMinus.scoreValue >= 100)
        {
            delapanpuluh.SetActive(false);
            duapuluh.SetActive(false);
            limapuluh.SetActive(false);
            sembilanpuluh.SetActive(false);
            seratus.SetActive(true);
        }


    }
}
